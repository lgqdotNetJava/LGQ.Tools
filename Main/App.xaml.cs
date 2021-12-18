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
        //License:NTQ4MzIzQDMxMzkyZTMzMmUzMG01TyttcjliR1NrVW90eExLVmx2ZEptb3hBSEk2TGp3UllER0lZTkQ4T0U9

        public App()
        {
        }

        protected override Window CreateShell()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTQ4MzIzQDMxMzkyZTMzMmUzMG01TyttcjliR1NrVW90eExLVmx2ZEptb3hBSEk2TGp3UllER0lZTkQ4T0U9");
            if (!IsLogin)
            {
                var loginWindow = Container.Resolve<LoginWindow>();
                loginWindow.ShowDialog();
            }
            //不能直接在构造函数中使用，会导致在MainWindow设置成Shell之前关闭应用
            ShutdownMode = ShutdownMode.OnMainWindowClose;
            return Container.Resolve<MainWindow>();
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
