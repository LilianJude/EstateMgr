using EstateMgrCore.Commands;
using EstateMgrCore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace EstateMgrCore.ViewModels
{
    public class EstateWindowModel : BaseNotifyPropertyChanged
       
    {

        private BaseNotifyPropertyChanged parentViewModel;

        public ObservableCollection<Estate> Estates
        {
            get { return GetProperty<ObservableCollection<Estate>>(); }
            private set { SetProperty(value); }
        }

        public ObservableCollection<Photos> Photos
        {
            get { return GetProperty<ObservableCollection<Photos>>(); }
            private set { SetProperty(value); }
        }

        public Estate SelectedEstate
        {
            get { return GetProperty<Estate>(); }
            set { SetProperty(value); }
        }

        public Photos CurrentPicture
        {
            get { return GetProperty<Photos>(); }
            set { SetProperty(value); }
        }

        public Transaction CurrentTransaction
        {
            get { return GetProperty<Transaction>(); }
            set { SetProperty(value); }
        }

        public Models.Estate.typeEstate TypeEstate
        {
            get => GetProperty<Models.Estate.typeEstate>();
            set => SetProperty(value);
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
                property?.SetValue(parentViewModel, value);
            }
        }

        public EstateWindowModel(BaseNotifyPropertyChanged mwvm)
        {
            parentViewModel = mwvm;
            this.Estates = new ObservableCollection<Estate>();
            this.Photos = new ObservableCollection<Photos>();

            Array list = DataAccess.AgencyDbContext.Current.Estate.ToArray();
            for (int i = 0; i < list.Length; i++)
            {
                this.Estates.Add((Estate)list.GetValue(i));
            }

            SelectedEstate = Estates[1];

            Array transactions = DataAccess.AgencyDbContext.Current.Transaction.Where(p => p.EstateId == SelectedEstate.Id).ToArray();
            Array photos = DataAccess.AgencyDbContext.Current.Photos.Where(p => p.EstateId == SelectedEstate.Id).ToArray();

            CurrentPicture = (Photos)photos.GetValue(0);
            CurrentTransaction = (Transaction)transactions.GetValue(0);
        }
    }
}
