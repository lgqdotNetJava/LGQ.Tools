﻿using LGQ.Tools.Share;

namespace Main.Entites
{
    public class LoginInfo:NotifyPropertyChangedEntity
    {
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }


        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
    }
}
