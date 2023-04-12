using CommunicationsShowroom.DbEntity;
using CommunicationsShowroom.View;
using CommunicationsShowroom.View.Window;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CommunicationsShowroom.ViewModel
{
    public class AutorizVM : BaseViewModel
    {
        private string _buttonDescription = "Войти";
        public AccountClient _accountClient;
        public AccountEmployees _accountEmployees;
        public Client client;
        private string _login;
        private string _password;

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public string ButtonDes
        {
            get => _buttonDescription;
            set
            {
                _buttonDescription = value;
                OnPropertyChanged(nameof(ButtonDes));
            }
        }
        public async Task<bool> Authorizations(string login, string password)
        {
            try
            {

                var resultClient = await DbStorage.Db.AccountClient.FirstOrDefaultAsync(client => client.LoginClient == login && client.PasswordClient == password);
                _accountClient = resultClient;
                var resultEmployees = await DbStorage.Db.AccountEmployees.FirstOrDefaultAsync(employees => employees.LoginEmployees == login && employees.PasswordEmployees == password);
                _accountEmployees = resultEmployees;
                if (resultClient != null || _accountEmployees != null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Исключения!", MessageBoxButton.OK, MessageBoxImage.Stop);
                return false;
            }
        }

        public async void AuthorInApp()
        {
            ButtonDes = "Подождите";

            if (await Authorizations(Login, Password))
            {
                if(_accountEmployees != null)
                {
                    if (_accountEmployees.Id_Status == 1)
                    {
                        var role = 1;
                        var mainMenu = new MainMenu(_accountEmployees, role);
                        mainMenu.Show();
                    }

                    if (_accountEmployees.Id_Status == 2)
                    {
                        var role = 2;
                        var mainMenu = new MainMenu(_accountEmployees, role);
                        mainMenu.Show();
                    }
                    if (_accountEmployees.Id_Status == 4)
                    {
                        var role = 4;
                        var mainMenu = new MainMenu(_accountEmployees, role);
                        mainMenu.Show();
                    }
                }
                if (_accountClient != null)
                {
                    if (_accountClient.Id_Status == 1)
                    {
                        //var role = 1;
                        //var Autorization = new AdminWindow(_accountEmployees, role);
                        //Autorization.Show();
                    }

                    if (_accountClient.Id_Status == 2)
                    {
                       
                    }
                    if (_accountClient.Id_Status == 3)
                    {
                       
                    }
                    if (_accountClient.Id_Status == 4)
                    {
                        
                    }         
                }
              
                foreach (var item in App.Current.Windows)
                {
                    if (item is Autorization)
                    {
                        (item as Window)?.Hide();
                    }
                }
                ButtonDes = "Подождите";
                return;
            }
            MessageBox.Show("Неверный логин или пароль", "Авторизация!", MessageBoxButton.OK, MessageBoxImage.Error);
            ButtonDes = "Войти";
        }
    }
}

