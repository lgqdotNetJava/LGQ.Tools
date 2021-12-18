using OAModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace OAModule
{
    public class OAModuleModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<WorkOrderListView>("WorkOrderList");
        }
    }
}