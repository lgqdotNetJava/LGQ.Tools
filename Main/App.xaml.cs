using Main.PrismAdapter;
using Main.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using Syncfusion.Windows.Tools.Controls;
using System.Windows;

namespace Main
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : PrismApplication
    {
        bool IsLogin = false;
        //License:NTYwNzc5QDMxMzkyZTM0MmUzMEYvdEw5TkFmTlNqYWxxUWN2K0pGMEY0eWRjYlFBeXdtT1FraEFZY0FLTVU9

        public App()
        {
        }

        protected override Window CreateShell()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTYwNzc5QDMxMzkyZTM0MmUzMEYvdEw5TkFmTlNqYWxxUWN2K0pGMEY0eWRjYlFBeXdtT1FraEFZY0FLTVU9");
            if (!IsLogin)
            {
                var loginWindow = Container.Resolve<LoginWindow>();
                bool? result= loginWindow.ShowDialog();
            }
            //不能直接在构造函数中使用，会导致在MainWindow设置成Shell之前关闭应用
            try
            {
                ShutdownMode = ShutdownMode.OnMainWindowClose;
                return Container.Resolve<MainWindow>();
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<PersonModule.PersonModule>();
            moduleCatalog.AddModule<OAModule.OAModuleModule>();
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(TabControlExt), Container.Resolve<TabControlExtRegionAdapter>());
        }
    }
}
