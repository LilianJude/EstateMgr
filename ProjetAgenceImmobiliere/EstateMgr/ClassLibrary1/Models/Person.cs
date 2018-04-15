using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstateMgrCore.Models
{
    public class Person : ViewModels.BaseNotifyPropertyChanged
    {
        public enum types { Morale, Physic};

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        public types Type
        {
            get { return GetProperty<types>(); }
            set { SetProperty(value); }
        }

        public String Name
        {
            get { return GetProperty<String>(); }
            set {
                if (SetProperty(value)) {
                    OnPropertyChanged(nameof(FullName));

                }
                }
        }

        public String FirstName
        {
            get { return GetProperty<String>(); }
            set
            {
                if (SetProperty(value))
                {
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }

        public int AddressId
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        public String Phone
        {
            get { return GetProperty<String>(); }
            set { SetProperty(value); }
        }

        public String CellPhone
        {
            get { return GetProperty<String>(); }
            set { SetProperty(value); }
        }

        public String Mail
        {
            get { return GetProperty<String>(); }
            set { SetProperty(value); }
        }
        public int Referent
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        [ForeignKey(nameof(AddressId))]
        public Address AddressPerson { get; set; }

        [InverseProperty(nameof(Estate.Referent))]
        public ObservableCollection<Estate> Estates_Ref
        {
            get { return GetProperty<ObservableCollection<Estate>>(); }
            protected set { SetProperty(value); }
        }

        [InverseProperty(nameof(Estate.Owner))]
        public ObservableCollection<Estate> Estates_Owner
        {
            get { return GetProperty<ObservableCollection<Estate>>(); }
            protected set { SetProperty(value); }
        }

        [InverseProperty(nameof(Transaction.ClientTransaction))]
        public ObservableCollection<Transaction> Transactions_client
        {
            get { return GetProperty<ObservableCollection<Transaction>>(); }
            protected set { SetProperty(value); }
        }

        [NotMapped]
        public string FullName
        {
            get { return FirstName + " " + Name; }
        }

    }
}
