using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Yudashev.Contexts;
using Yudashev.Models;

namespace Yudashev.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private IEnumerable<User> _Users;
        public IEnumerable<User> Users
        {
            get { return _Users; }
            set
            {
                _Users = value; OnPropertyChanged();
            }

        }

        public MainViewModel()
        {
            GetUser();
        }

        private void GetUser()
        {
            using(var context=new UserContext())
            {
                Users=context.Users.ToList();
            }
        }
    }
}
