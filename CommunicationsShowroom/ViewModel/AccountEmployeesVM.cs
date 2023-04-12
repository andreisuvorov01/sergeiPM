using CommunicationsShowroom.DbEntity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CommunicationsShowroom.ViewModel
{
    public class AccountEmployeesVM : BaseViewModel
    {
        private ObservableCollection<AccountEmployees> _accountEmployees;

        private AccountEmployees _accountEmployee;

        public AccountEmployeesVM()
        {
            AccountEmployees = new ObservableCollection<AccountEmployees>();
            LoadData();
        }
        public ObservableCollection<AccountEmployees> AccountEmployees
        {
            get => _accountEmployees;
            set
            {
                _accountEmployees = value;
                OnPropertyChanged(nameof(AccountEmployees));
            }
        }

        public AccountEmployees SelectAccountEmployees
        {
            get => _accountEmployee;
            set
            {
                _accountEmployee = value;
                OnPropertyChanged(nameof(SelectAccountEmployees));
            }
        }
        public void LoadData()
        {
            if (_accountEmployees.Count > 0)
            {
                _accountEmployees.Clear();
            }

            var result = DbStorage.Db.AccountEmployees.ToList();

            result.ForEach(a => AccountEmployees?.Add(a));
        }

        public void DeleteData()

        {
           
                using (var Db = new CommunicationsShowroomEntities())
                {
                    var result = MessageBox.Show("Вы действительно хотите удалить запись\n" + "Это нельзя будет отменить", "Предупреждения", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (result == MessageBoxResult.Yes)
                    {
                        try
                        {
                            var entityForDelete = Db.AccountClient.Where(user => user.Id == SelectAccountEmployees.Id).FirstOrDefault();
                            Db.AccountClient.Remove(entityForDelete);
                            Db.SaveChanges();
                            LoadData();
                            MessageBox.Show("Вы успешно удалили объект", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                            return;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

                        }
                    }
                }
            
        }
    }
}
