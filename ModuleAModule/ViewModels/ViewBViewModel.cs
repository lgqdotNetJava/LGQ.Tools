using Prism.Regions;
using Prism.Mvvm;
using LGQ.Tools.Share;

namespace ModuleA.ViewModels
{
    public class ViewBViewModel : BaseViewModel,INavigationAware
    {
        public ViewBViewModel()
        {

        }
        private string _title = "ViewB";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
    }
}
