using Main.ViewModels;
using Prism.Ioc;
using System.ComponentModel;
using System.Windows;

namespace Main.Views
{
    /// <summary>
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly IContainerExtension _container;
        private readonly LoginWindowViewModel _viewModel;

        public LoginWindow(IContainerExtension container)
        {
            InitializeComponent();
            _container = container;

            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                _viewModel = new LoginWindowViewModel();
                //_viewModel.LoginSuccess += OnLoginSuccess;
                DataContext = _viewModel;
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OnLoginSuccess()
        {
            var mainWindow = _container.Resolve<MainWindow>();
            mainWindow.Show();
            Close();
        }
    }
}
