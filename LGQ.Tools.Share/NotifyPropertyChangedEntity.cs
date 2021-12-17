using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LGQ.Tools.Share
{
    public abstract class NotifyPropertyChangedEntity : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
