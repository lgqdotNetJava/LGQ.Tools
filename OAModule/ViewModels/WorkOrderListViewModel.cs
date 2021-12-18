using LGQ.Tools.Share;
using OAModule.Access;
using OAModule.Entities;
using Prism.Regions;
using System.Collections.ObjectModel;

namespace OAModule.ViewModels
{
    public class WorkOrderListViewModel : BaseViewModel
    {
        IRegionManager _regionManager;

        private string _title = "工单";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private ObservableCollection<WorkOrder> _workOrderList;
        public ObservableCollection<WorkOrder> WorkOrderList
        {
            get { return _workOrderList; }
            set { SetProperty(ref _workOrderList, value); }
        }

        public WorkOrderListViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            LoadWorkOrderList();
        }

        private void LoadWorkOrderList()
        {
            WorkOrderList =new ObservableCollection<WorkOrder>(WorkOrderAccess.GetList());
        }
    }
}
