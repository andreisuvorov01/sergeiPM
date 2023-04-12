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
    public class SalesVM :BaseViewModel
    {
        private ObservableCollection<Sales> _sales;

        private Sales _sale;

        public SalesVM()
        {
            Sales = new ObservableCollection<Sales>();
            LoadData();
        }
        public ObservableCollection<Sales> Sales
        {
            get => _sales;
            set
            {
                _sales = value;
                OnPropertyChanged(nameof(Sales));
            }
        }

        public Sales SelectSales
        {
            get => _sale;
            set
            {
                _sale = value;
                OnPropertyChanged(nameof(SelectSales));
            }
        }
        public void LoadData()
        {
            if (_sales.Count > 0)
            {
                _sales.Clear();
            }

            var result = DbStorage.Db.Sales.ToList();

            result.ForEach(a => Sales.Add(a));
        }

        public void DeleteData()

        {
            if (!(SelectSales is null))
            {
                using (var db = new CommunicationsShowroomEntities())
                {
                    var result = MessageBox.Show("Вы действительно хотите удалить запись\n" + "Это нельзя будет отменить", "Предупреждения", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (result == MessageBoxResult.Yes)
                    {
                        try
                        {
                            var entityForDelete = db.Sales.Where(user => user.Id == SelectSales.Id).FirstOrDefault();
                            db.Sales.Remove(entityForDelete);
                            db.SaveChanges();
                            LoadData();

                            MessageBox.Show("Вы успешно удалили объект", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
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
