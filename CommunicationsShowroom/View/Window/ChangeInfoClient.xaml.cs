using System;
using CommunicationsShowroom.DbEntity;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CommunicationsShowroom.View.Window
{
    /// <summary>
    /// Логика взаимодействия для ChangeInfoClient.xaml
    /// </summary>
    public partial class ChangeInfoClient 
    {
        private Client _client;
        public ChangeInfoClient(Client client)
        {
            InitializeComponent();
            if (client is null)
            {
                _client = client = new Client();
            }
            else
            {
                _client = client;
            }

            this.DataContext = _client;
        }
        public void btnSaveAccount_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new CommunicationsShowroomEntities())
            {
                try
                {
                    var validateEntity = ValidateEntity();
                    if (validateEntity.Length > 0)
                    {
                        MessageBox.Show(validateEntity.ToString(), "Информация", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    db.Client.AddOrUpdate(_client);
                    db.SaveChanges();

                    MessageBox.Show("Данные успешно внесены", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

                    (Owner as MainMenu)?.RefrashDataTable();
                    Owner?.Focus();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Информация", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
        }
        private StringBuilder ValidateEntity()
        {
            var error = new StringBuilder();
            if (_client != null)
            {
                //if (string.IsNullOrEmpty(_device.Name))
                //{
                //    error.AppendLine("Поле названия пустое");
                //}

                //if (_device.Cost <= 0)
                //{
                //    error.AppendLine("Стоимость не может быть отрицательной или введены символы!");
                //}

            }
            return error;
        }
        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MinimizeWindow_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
