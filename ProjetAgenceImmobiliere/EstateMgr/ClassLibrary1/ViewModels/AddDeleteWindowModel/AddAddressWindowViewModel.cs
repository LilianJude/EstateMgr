using System;
using System.Collections.Generic;
using System.Text;

namespace EstateMgrCore.ViewModels.AddDeleteWindowModel
{
    public class AddAddressWindowViewModel : BaseNotifyPropertyChanged
    {
        public Models.Address CurrentAddress
        {
            get => GetProperty<Models.Address>();
            set => SetProperty(value);
        }

        public Commande.BaseCommand<Object> OKCommand
        {
            get => new Commande.BaseCommand<Object>(View =>
              {
                  DataAccess.AgencyDbContext.Current.Address.Add(CurrentAddress);
                  DataAccess.AgencyDbContext.Current.SaveChanges();
                  NavigationService.Close(View, true);
              });
        }
        public AddAddressWindowViewModel()
        {
            CurrentAddress = new Models.Address();
        }

    }
}
