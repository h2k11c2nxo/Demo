using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FunitureExample.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void Initialize() { }
        public virtual void OnAppearing() { }
        public virtual void OnDisappearing() { }
    }
}
