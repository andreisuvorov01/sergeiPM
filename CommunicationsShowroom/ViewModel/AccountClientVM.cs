using CommunicationsShowroom.DbEntity;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace CommunicationsShowroom.ViewModel
{
    public class AccountClientVM : BaseViewModel
    {
        private ObservableCollection<AccountClient> _accountClients;

        private AccountClient _selectedAccountClient;
        public AccountClient SelectedAccountClient
        {
            get => _selectedAccountClient;
            set
            {
                _selectedAccountClient = value;
                OnPropertyChanged(nameof(SelectedAccountClient));
            }
        }
        public AccountClientVM()
        {
            AccountClients = new ObservableCollection<AccountClient>();
            LoadData();
        }
        public ObservableCollection<AccountClient> AccountClients
        {
            get => _accountClients;
            set
            {
                _accountClients = value;
                OnPropertyChanged(nameof(AccountClients));
            }
        }

       
        public void LoadData()
        {
            if (_accountClients.Count > 0)
            {
                _accountClients.Clear();
            }

            var result = DbStorage.Db.AccountClient.ToList();

            result.ForEach(a => AccountClients.Add(a));
        }


        public void DeleteData()
        {
            if (SelectedAccountClient != null)
            {
                using (var db = new CommunicationsShowroomEntities())
                {
                    var accountClient = db.AccountClient.Find(SelectedAccountClient.Id);
                    if (accountClient != null)
                    {
                        db.AccountClient.Remove(accountClient);
                        db.SaveChanges();
                        SelectedAccountClient = null;
                        LoadData();
                        MessageBox.Show("Объект успешно удален", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите объект для удаления", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
