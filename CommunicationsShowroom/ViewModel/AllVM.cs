using CommunicationsShowroom.DbEntity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace CommunicationsShowroom.ViewModel
{
    public class AllVM : BaseViewModel
    {
        private ObservableCollection<AccountClient> _accountClients;
        private AccountClient _selectAccountClient;


        public AllVM(AccountEmployees accountEmployees, int role)
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
        public AccountClient SelectAccountClient
        {
            get => _selectAccountClient;
            set
            {
                _selectAccountClient = value;
                OnPropertyChanged(nameof(SelectAccountClient));
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
            if (!(SelectAccountClient is null))
            {
                using (var db = new CommunicationsShowroomEntities())
                {
                    var result = System.Windows.MessageBox.Show("Вы действительно хотите удалить запись\n" + "Это нельзя будет отменить", "Предупреждения", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (result == MessageBoxResult.Yes)
                    {
                        try
                        {
                            var entityForDelete = db.AccountClient.Where(user => user.Id == SelectAccountClient.Id).FirstOrDefault();
                            db.AccountClient.Remove(entityForDelete);
                            db.SaveChanges();
                            LoadData();
                            System.Windows.MessageBox.Show("Вы успешно удалили объект", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                            return;
                        }
                        catch (Exception ex)
                        {
                            System.Windows.MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
            }
        }
    }
}
