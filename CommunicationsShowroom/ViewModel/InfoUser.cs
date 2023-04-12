using CommunicationsShowroom.DbEntity;
using CommunicationsShowroom.View.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationsShowroom.ViewModel
{
    public class InfoUser:BaseViewModel
    {

        private string _lastname;
        private string _name;
        private string _position;

        public string Position
        {
            get => _position;
            set
            {
                _position = value;
                OnPropertyChanged(nameof(Position));
            }
        }
        public string Lastname
        {
            get => _lastname;
            set
            {
                _lastname = value;
                OnPropertyChanged(nameof(Lastname));
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public InfoUser(AccountEmployees accountEmployees)
        {
            Name = accountEmployees.InfoEmployees.Name;
            Lastname = accountEmployees.InfoEmployees.LastName;
            Position = accountEmployees.InfoEmployees.Position;
        }

        internal static void Navigate(InfoUserPage infoUserPage)
        {
            throw new NotImplementedException();
        }
    }
}
