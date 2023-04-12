using CommunicationsShowroom.DbEntity;
using CommunicationsShowroom.View.Page;
using CommunicationsShowroom.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CommunicationsShowroom.View.Window
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu
    {
        public InfoEmployees infoEmployees;
        public int role = 1;
        private AccountEmployees _accountEmployees;
        public static MainMenu mainMenu;
        private readonly AccountClientVM _accountClientVM;

        public AccountEmployees AccountEmployees
        {
            get => _accountEmployees;
            set
            {
                _accountEmployees = value;
            }
        }
        public MainMenu(AccountEmployees accountEmployees, int role)
        {

            _accountClientVM = new AccountClientVM();
            InitializeComponent();  
            FramePageAdmin.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            mainMenu = this;

            TableComboAdmin.SelectedIndex = 0;
            //InfoUser.Navigate(new InfoUserPage(accountEmployees));
            if (role == 1)
            {
                TableComboAdmin.ItemsSource = new Table[]
             {
                new Table { Name = "Устройства"},
                new Table { Name = "Заказы на ремонт"},
                new Table { Name = "Аккаунты клиентов"},
                new Table { Name = "Аккаунты сотрудников"},
                new Table { Name = "Продажи"},
                new Table { Name = "Инф. клиентов"},
                new Table { Name = "Инф. сотрудников"}
             };
                DeleteButton.Visibility = Visibility.Visible;
                EditButton.Visibility = Visibility.Visible;
                InsertButton.Visibility = Visibility.Visible;
                Position.Content = " Администратор";
            }
            if (role == 2)
            {
                TableComboAdmin.ItemsSource = new Table[]
              {
                new Table { Name = "Устройства"},
                new Table { Name = "Заказы на ремонт"},
                new Table { Name = "Продажи"},
                new Table { Name = "Инф. клиентов"},
                new Table { Name = "Инф. сотрудников"}
              };
                EditButton.Visibility = Visibility.Visible;
                InsertButton.Visibility = Visibility.Visible;
                Position.Content = "Менеджер";
            }
            if (role == 4)
            {
                InsertButton.Visibility = Visibility.Visible;
                Position.Content = "Сотрудник";
                TableComboAdmin.ItemsSource = new Table[]
             {
                new Table { Name = "Устройства"},
                new Table { Name = "Заказы на ремонт"},
                new Table { Name = "Продажи"}
             };
            }
        }
        private void Drag(object sender, RoutedEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                MainMenu.mainMenu.DragMove();
            }
        }
        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MinimizeWindow_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Autorization autorization = new Autorization();
            autorization.Show();
            this.Close();
        }

        private void adminComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TableComboAdmin.SelectedIndex == 0)
            {
                FramePageAdmin.Navigate(new DevicePage(_accountEmployees, role));
            }
            if (TableComboAdmin.SelectedIndex == 1)
            {
                FramePageAdmin.Navigate(new RepairOrdersPage(_accountEmployees, role));
            }
            if (TableComboAdmin.SelectedIndex == 2)
            {
                FramePageAdmin.Navigate(new AccountClientPage{ DataContext = _accountClientVM });
            }
            if (TableComboAdmin.SelectedIndex == 3)
            {
                FramePageAdmin.Navigate(new AccountEmployeesPage(_accountEmployees, role));
            }
            if (TableComboAdmin.SelectedIndex == 4)
            {
                FramePageAdmin.Navigate(new SalesPage(_accountEmployees, role));
            }
            if (TableComboAdmin.SelectedIndex == 5)
            {
                FramePageAdmin.Navigate(new InfoClientPage(_accountEmployees, role));
            }
            if (TableComboAdmin.SelectedIndex == 6)
            {
                FramePageAdmin.Navigate(new InfoEmployeesPage(_accountEmployees, role));
            }

        }

        public void RefrashDataTable()
        {
            (DataContext as DevicePageVM).LoadData();
        }

        public class Table
        {
            public string Name { get; set; } = "";
            public override string ToString() => $"{Name}";
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            switch (TableComboAdmin.SelectedIndex)
            {
                case 0:
                    {
                        (DataContext as DevicePageVM).DeleteData();
                    }
                    break;
                case 1:
                    {
                        (DataContext as RepairOrdersVM).DeleteData();
                    }
                    break;
                case 2:
                    {
                        _accountClientVM.DeleteData();
                    }
                    break;
                case 3:
                    {
                        (DataContext as AccountEmployeesVM).DeleteData();
                    }
                    break;
                case 4:
                    {
                        (DataContext as SalesVM).DeleteData();
                    }
                    break;
                case 5:
                    {
                        (DataContext as SalesVM).DeleteData();
                    }
                    break;
                case 6:
                    {
                        (DataContext as InfoEmployeesVM).DeleteData();
                    }
                    break;
                default:
                    break;
            }
        }
        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            switch (TableComboAdmin.SelectedIndex)
            {
                case 0:
                    {
                        var changeTableDevice = new ChangeTableDevice(null);
                        changeTableDevice.Show();
                    }
                    break;
                case 1:
                    {
                        var changeTableDevice = new ChangeTableRepairOrder(null);
                        changeTableDevice.Show();
                    }
                    break;
                case 2:
                    {
                        var changeTableAccountClient = new ChangeTableAccountClient(null);
                        changeTableAccountClient.Show();
                    }
                    break;
                case 3:
                    {
                        var changeTableAccountClient = new ChangeTableAccountEmployees(null);
                        changeTableAccountClient.Show();
                    }
                    break;
                case 4:
                    {
                        var сhangeTableSales = new ChangeTableSales(null);
                        сhangeTableSales.Show();
                    }
                    break;
                case 5:
                    {
                        var changeInfoClient = new ChangeInfoClient(null);
                        changeInfoClient.Show();
                    }
                    break;
                case 6:
                    {
                        var changeInfoEmployees = new ChangeInfoEmployees(null);
                        changeInfoEmployees.Show();
                    }
                    break;
                default:
                    break;
            }
        }


        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            switch (TableComboAdmin.SelectedIndex)
             {
            case 0:
                {
                    var changeTableDevice = new ChangeTableDevice((DataContext as DevicePageVM).SelectDevice);
                    changeTableDevice.Show();
                }
                break;
            case 1:
                {
                    var changeTableRepairOrder = new ChangeTableRepairOrder((DataContext as RepairOrdersVM).SelectRepairOrders);
                    changeTableRepairOrder.Show();
                }
                break;
            case 2:
                {
                    var changeTableAccountClient = new ChangeTableAccountClient((DataContext as AccountClientVM).SelectedAccountClient);
                    changeTableAccountClient.Show();
                }
                break;
            case 3:
                {
                    var changeTableAccountClient = new ChangeTableAccountEmployees((DataContext as AccountEmployeesVM).SelectAccountEmployees);
                    changeTableAccountClient.Show();
                }
                break;
            case 4:
                {
                    var changeTableAccountClient = new ChangeTableSales((DataContext as SalesVM).SelectSales);
                    changeTableAccountClient.Show();
                }
                break;
            case 5:
                {
                    var changeInfoClient = new ChangeInfoClient((DataContext as InfoClientVM).SelectClient);
                    changeInfoClient.Show();
                }
                break;
            case 6:
                {
                    var changeInfoEmployees = new ChangeInfoEmployees((DataContext as InfoEmployeesVM).SelectInfoEmployees);
                    changeInfoEmployees.Show();
                }
                break;
                default:
                    break;

            }
        }


    }
}
