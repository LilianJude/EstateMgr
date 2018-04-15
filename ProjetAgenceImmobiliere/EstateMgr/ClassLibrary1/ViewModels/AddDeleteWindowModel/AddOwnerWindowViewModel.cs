using System;
using System.Collections.Generic;
using System.Text;

namespace EstateMgrCore.ViewModels.AddDeleteWindowModel
{
    public class AddOwnerWindowViewModel : BaseNotifyPropertyChanged
    {
        private void OnEstatePropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Models.Person.AddressId))
            {
                OnPropertyChanged(nameof(ShowAddressBtn));
                OnPropertyChanged(nameof(ShowAddress));
            }
            
        }
        public Models.Person CurrentOwner
        {
            get => GetProperty<Models.Person>();
            set
            {
                if (SetProperty(value))
                {
                    value.PropertyChanged += OnEstatePropertyChanged;
                }
            }
        }
        public string ShowAddressText
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
        public bool ShowAddressBtn
        {
            get => CurrentOwner?.AddressId != null;
        }
        public bool ShowAddress
        {
            get => !ShowAddressBtn;
        }
        public Commande.BaseCommand<Object> OKCommand
        {
            get => new Commande.BaseCommand<Object>(View =>
            {
                DataAccess.AgencyDbContext.Current.Person.Add(CurrentOwner);
                DataAccess.AgencyDbContext.Current.SaveChanges();
                NavigationService.Close(View, true);
            });
        }
        public Commande.BaseCommand<Type> OpenAddressCommand
        {
            get => new Commande.BaseCommand<Type>(TView =>
            {
                AddAddressWindowViewModel vm = new AddAddressWindowViewModel();
                if (NavigationService.ShowDialog(TView, vm) == true)
                {
                    CurrentOwner.AddressId = vm.CurrentAddress.Id;
                    ShowAddressText = "Adresse bien ajoutée !";
                }
            });
        }
        public AddOwnerWindowViewModel()
        {
            CurrentOwner = new Models.Person();
        }
    }
}
