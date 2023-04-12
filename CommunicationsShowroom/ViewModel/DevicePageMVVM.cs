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
    public class DevicePageMVVM :BaseViewModel
    {
        private ObservableCollection<Device> _devices;

        private Device _SelectDevice;

        public DevicePageMVVM()
        {
            Devices = new ObservableCollection<Device>();
            LoadData();
        }
        public ObservableCollection<Device> Devices
        {
            get => _devices;
            set
            {
                _devices = value;
                OnPropertyChanged(nameof(Devices));
            }
        }

        public Device SelectDevice
        {
            get => _SelectDevice;
            set
            {
                _SelectDevice = value;
                OnPropertyChanged(nameof(SelectDevice));
            }
        }


        public void LoadData()
        {
            if (_devices.Count > 0)
            {
                _devices.Clear();
            }

            var result = DbStorage.Db.Device.ToList();

            result.ForEach(a => Devices.Add(a));
        }

        public void DeleteData()
        {
            if (!(SelectDevice is null))
            {
                using (var db = new CommunicationsShowroomEntities())
                {

                    var result = MessageBox.Show("Вы действительно хотите удалить запись\n" + "Это нельзя будет отменить", "Предупреждения", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (result == MessageBoxResult.Yes)
                    {
                        try
                        {
                            var entityForDelete = db.Device.Where(user => user.Id == SelectDevice.Id).FirstOrDefault();
                            db.Device.Remove(entityForDelete);
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
