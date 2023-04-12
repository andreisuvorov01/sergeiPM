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
    public class InfoClientVM:BaseViewModel
    {
        private ObservableCollection<Client> _clients;

        private Client _client;

        public InfoClientVM()
        {
            Clients = new ObservableCollection<Client>();
            LoadData();
        }
        public ObservableCollection<Client> Clients
        {
            get => _clients;
            set
            {
                _clients = value;
                OnPropertyChanged(nameof(Clients));
            }
        }

        public Client SelectClient
        {
            get => _client;
            set
            {
                _client = value;
                OnPropertyChanged(nameof(SelectClient));
            }
        }
        public void LoadData()
        {
            if (_clients.Count > 0)
            {
                _clients.Clear();
            }

            var result = DbStorage.Db.Client.ToList();

            result.ForEach(a => Clients?.Add(a));
        }

        public void DeleteData()

        {
            if (!(SelectClient is null))
            {
                using (var db = new CommunicationsShowroomEntities())
                {
                    var result = MessageBox.Show("Вы действительно хотите удалить запись\n" + "Это нельзя будет отменить", "Предупреждения", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (result == MessageBoxResult.Yes)
                    {
                        try
                        {
                            var entityForDelete = db.Client.Where(user => user.Id == SelectClient.Id).FirstOrDefault();
                            db.Client.Remove(entityForDelete);
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
