using System;
using System.Collections.Generic;
using System.Text;

namespace EstateMgrCore.ViewModels
{
    public class PageViewModel : BaseNotifyPropertyChanged
    {
        public string Title
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        public PageViewModel()
        {
            Title = "Page1";
        }
    }
}
