using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstateMgrCore.Models
{
    public class Transaction : ViewModels.BaseNotifyPropertyChanged
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }
        public int EstateId
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }
        public int ClientId
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }
        public String Title
        {
            get { return GetProperty<String>(); }
            set { SetProperty(value); }
        }
        public String Description
        {
            get { return GetProperty<String>(); }
            set { SetProperty(value); }
        }
        public String CreationDate
        {
            get { return GetProperty<String>(); }
            set { SetProperty(value); }
        }
        public String TransactionDate
        {
            get { return GetProperty<String>(); }
            set { SetProperty(value); }
        }

        [ForeignKey(nameof(EstateId))]
        public Estate EstateTransaction { get; set; }

        [ForeignKey(nameof(ClientId))]
        public Person ClientTransaction { get; set; }

        [InverseProperty(nameof(SaleTransaction.Transaction))]
        public ObservableCollection<SaleTransaction> Sale_Transactions
        {
            get { return GetProperty<ObservableCollection<SaleTransaction>>(); }
            protected set { SetProperty(value); }
        }

        [InverseProperty(nameof(RentTransaction.Transaction))]
        public ObservableCollection<RentTransaction> Rent_Transactions
        {
            get { return GetProperty<ObservableCollection<RentTransaction>>(); }
            protected set { SetProperty(value); }
        }

       
    }
}
