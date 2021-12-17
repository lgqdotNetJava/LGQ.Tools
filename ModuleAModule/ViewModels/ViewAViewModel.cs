using Prism.Regions;
using Prism.Mvvm;
using LGQ.Tools.Share;

namespace ModuleA.ViewModels
{
    public class ViewAViewModel : BaseViewModel,INavigationAware
    {
        private string _title = "ViewA";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ViewAViewModel()
        {

        }
    }
}
