using LGQ.Tools.Share;
using OAModule.Access;
using OAModule.Entities;
using Prism.Commands;
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
        public DelegateCommand WorkOrderListQueryCommand { get; private set; }

        private ObservableCollection<WorkOrder> _workOrderList;
        public ObservableCollection<WorkOrder> WorkOrderList
        {
            get { return _workOrderList; }
            set { SetProperty(ref _workOrderList, value); }
        }

        public WorkOrderListViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            WorkOrderListQueryCommand = new DelegateCommand(LoadWorkOrderList);
            LoadWorkOrderList();
        }

        private void LoadWorkOrderList()
        {
            WorkOrderList = new ObservableCollection<WorkOrder>(WorkOrderAccess.GetList());
            WorkOrderList.Add(
                new WorkOrder
                {
                    ID = 1,
                    OA_ID = 2
                }
                );
        }
    }
}
