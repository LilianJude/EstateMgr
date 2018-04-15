using EstateMgrCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstateMgrCore.ViewModels.AddDeleteWindowModel
{
    public class AddDeleteWindowViewModel : BaseNotifyPropertyChanged
    {
        private BaseNotifyPropertyChanged parentViewModel;
        public BaseCommand<Type> LoadAddWindow
        {
            get => new BaseCommand<Type>((type) =>
            {
                CurrentWindow = NavigationService.GetView<AddWindowModel>(type);
            });
        }
        public BaseCommand<Type> LoadDeleteWindow
        {
            get => new BaseCommand<Type>((type) =>
            {
                CurrentWindow = NavigationService.GetView<DeleteWindowModel>(type);
            });
        }
        public object CurrentWindow
        {
            get
            {
                var property = parentViewModel.GetType().GetProperty("CurrentWindow");
                return property?.GetValue(parentViewModel);

             }
            private set
            {
                var property = parentViewModel.GetType().GetProperty("CurrentWindow");
                property?.SetValue(parentViewModel,value);
            }
        }


        public AddDeleteWindowViewModel(BaseNotifyPropertyChanged mwvm)
        {
            parentViewModel = mwvm;
        }
      
    }
}
