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
    public class InfoEmployeesVM:BaseViewModel
    {
        private ObservableCollection<InfoEmployees> _employees;

        private InfoEmployees _employee;

        public InfoEmployeesVM()
        {
            Employees = new ObservableCollection<InfoEmployees>();
            LoadData();
        }
        public ObservableCollection<InfoEmployees> Employees
        {
            get => _employees;
            set
            {
                _employees = value;
                OnPropertyChanged(nameof(Employees));
            }
        }

        public InfoEmployees SelectInfoEmployees
        {
            get => _employee;
            set
            {
                _employee = value;
                OnPropertyChanged(nameof(InfoEmployees));
            }
        }
        public void LoadData()
        {
            if (_employees.Count > 0)
            {
                _employees.Clear();
            }

            var result = DbStorage.Db.InfoEmployees.ToList();

            result.ForEach(a => Employees.Add(a));
        }

        public void DeleteData()

        {
            if (!(SelectInfoEmployees is null))
            {
                using (var db = new CommunicationsShowroomEntities())
                {
                    var result = MessageBox.Show("Вы действительно хотите удалить запись\n" + "Это нельзя будет отменить", "Предупреждения", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (result == MessageBoxResult.Yes)
                    {
                        try
                        {
                            var entityForDelete = db.InfoEmployees.Where(user => user.Id == SelectInfoEmployees.Id).FirstOrDefault();
                            db.InfoEmployees.Remove(entityForDelete);
                            db.SaveChanges();
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
}
