using EstateMgrCore.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace EstateMgrCore.ViewModels.AddDeleteWindowModel
{
    public class DeleteWindowModel : BaseNotifyPropertyChanged
    {
        public Commande.BaseCommand<Type> DeleteEstateCommand
        {
            get => new Commande.BaseCommand<Type>((type) =>
            {
                DataAccess.AgencyDbContext.Current.Transaction.Remove(SelectedEstate);
            });
        }
        public Transaction SelectedEstate
        {
            get { return GetProperty<Transaction>(); }
            set { SetProperty(value); }
        }
        public ObservableCollection<Transaction> Estates
        {
            get { return GetProperty<ObservableCollection<Transaction>>(); }
            private set { SetProperty(value); }
        }
        public DeleteWindowModel()
        {
            this.Estates = new ObservableCollection<Transaction>(DataAccess.AgencyDbContext.Current.Transaction.ToArray());
            if (this.Estates.Count > 0)
                this.SelectedEstate = this.Estates[0];
        }
    }
}
