
using EstateMgrCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstateMgrCore.Commande
{
    public class MainViewModel <TDefaultViewModel>: BaseNotifyPropertyChanged where TDefaultViewModel : BaseNotifyPropertyChanged
    {
        public BaseCommand<Type> OpenConsultation
        {
            get => new BaseCommand<Type>((type) =>
            {
                CurrentPage = NavigationService.GetView<PageViewModel>(type);
            });
        }
        public object CurrentPage { get; private set; }

    }
}
