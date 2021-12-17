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
        //License:NTQ4MzIzQDMxMzkyZTMzMmUzMG01TyttcjliR1NrVW90eExLVmx2ZEptb3hBSEk2TGp3UllER0lZTkQ4T0U9
        protected override Window CreateShell()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTQ4MzIzQDMxMzkyZTMzMmUzMG01TyttcjliR1NrVW90eExLVmx2ZEptb3hBSEk2TGp3UllER0lZTkQ4T0U9");
            return Container.Resolve<LoginWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(TabControlExt), Container.Resolve<TabControlExtRegionAdapter>());
        }
    }
}
