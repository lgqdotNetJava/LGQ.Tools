using Prism.Mvvm;
using Prism.Regions;

namespace LGQ.Tools.Share
{
    public abstract class BaseViewModel : BindableBase, INavigationAware
    {
        private bool m_IsTarget;

        public bool IsTarget
        {
            get { return m_IsTarget; }
            set { SetProperty(ref m_IsTarget, value); }
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return IsTarget;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            IsTarget = true;
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            IsTarget = false;
        }
    }
}
