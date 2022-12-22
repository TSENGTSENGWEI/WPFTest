using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFTest
{
    internal class NotifyPropertyChange : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public virtual void OnPropertyChange(string? propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        public void SetValue<T>(ref T stroage,T value, [CallerMemberName] string? propertyName = null)
        {
            if(!EqualityComparer<T>.Default.Equals(stroage,value) && propertyName!=null)
            {
                stroage = value;
                OnPropertyChange(propertyName);
            }
        }
    }
}
