using Main.Entites;
using Prism.Commands;
using Prism.Mvvm;
using System.Windows;

namespace Main.ViewModels
{
    public class LoginWindowViewModel : BindableBase
    {
        public delegate void LoginSucessHandler();

        public event LoginSucessHandler OnLoginSucess;

        private string _title = "登录";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private LoginInfo _loginInfo = new LoginInfo();
        public LoginInfo LoginInfo
        {
            get { return _loginInfo; }
            set { SetProperty(ref _loginInfo, value); }
        }

        public DelegateCommand<LoginInfo> LoginCommand { get; private set; }

        public LoginWindowViewModel()
        {
            LoginCommand = new DelegateCommand<LoginInfo>(Login);
            LoginInfo.UserName = "admin";
            LoginInfo.Password = "123456";
        }

        private void Login(LoginInfo loginInfo)
        {
            if (loginInfo.UserName == "admin" && loginInfo.Password == "123456")
            {
                OnLoginSucess();
            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }
    }
}
