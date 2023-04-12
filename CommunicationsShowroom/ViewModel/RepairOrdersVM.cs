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
    public class RepairOrdersVM: BaseViewModel
    {
        private ObservableCollection<RepairOrders> _repairOrders;

        private RepairOrders _repairOrder;

        public RepairOrdersVM()
        {
            RepairOrders = new ObservableCollection<RepairOrders>();
            LoadData();
        }
        public ObservableCollection<RepairOrders> RepairOrders
        {
            get => _repairOrders;
            set
            {
                _repairOrders = value;
                OnPropertyChanged(nameof(RepairOrders));
            }
        }

        public RepairOrders SelectRepairOrders
        {
            get => _repairOrder;
            set
            {
                _repairOrder = value;
                OnPropertyChanged(nameof(SelectRepairOrders));
            }
        }


        public void LoadData()
        {
            if (_repairOrders.Count > 0)
            {
                _repairOrders.Clear();
            }

            var result = DbStorage.Db.RepairOrders.ToList();

            result.ForEach(a => RepairOrders.Add(a));
        }

        public void DeleteData()

        {
            if (!(SelectRepairOrders is null))
            {
                using (var db = new CommunicationsShowroomEntities())
                {
                    var result = MessageBox.Show("Вы действительно хотите удалить запись\n" + "Это нельзя будет отменить", "Предупреждения", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (result == MessageBoxResult.Yes)
                    {
                        try
                        {
                            var entityForDelete = db.RepairOrders.Where(user => user.Id == SelectRepairOrders.Id).FirstOrDefault();
                            var unused = db.RepairOrders.Remove(entityForDelete);
                            var unused1 = db.SaveChanges();
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
