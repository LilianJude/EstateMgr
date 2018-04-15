using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstateMgrCore.Models
{
    public class Estate : ViewModels.BaseNotifyPropertyChanged
    {
      public enum typeEstate { house, flat, field, garage, commercial};

      [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public int Id
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

       public float Surface
        {
            get { return GetProperty<float>(); }
            set { SetProperty(value); }
        }

        public int OwnerId
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        public int AddressId
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        public int PropertyTax
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        public typeEstate Type
        {
            get { return GetProperty<typeEstate>(); }
            set { SetProperty(value); }
        }

        public int RoomsCount
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        public int FloorNumber
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        public int FloorsCount
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        public int ReferentId
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        [ForeignKey(nameof(ReferentId))]
        public Person Referent {
            get { return GetProperty<Person>(); }
            protected set { SetProperty(value); }
        }

        [ForeignKey(nameof(OwnerId))]
        public Person Owner {
            get { return GetProperty<Person>(); }
            set { SetProperty(value); }
        }

        [ForeignKey(nameof(AddressId))]
        public Address AddressEstate {
            get { return GetProperty<Address>(); }
            set { SetProperty(value); }
        }

        [InverseProperty(nameof(Transaction.EstateTransaction))]
        public ObservableCollection<Transaction> Estates_transactions
        {
            get { return GetProperty<ObservableCollection<Transaction>>(); }
            set { SetProperty(value); }
        }

        [InverseProperty(nameof(Photos.EstatePhoto))]
        public ObservableCollection<Photos> Estate_photos
        {
            get { return GetProperty<ObservableCollection<Photos>>(); }
            set { SetProperty(value); }
        }

        

    }
}
