using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstateMgrCore.Models
{
    public class Address : ViewModels.BaseNotifyPropertyChanged
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        public String Adrress
        {
            get { return GetProperty<String>(); }
            set { SetProperty(value); }
        }

        public int ZipCode
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        public String City
        {
            get { return GetProperty<String>(); }
            set { SetProperty(value); }
        }

        public double? Latitude
        {
            get { return GetProperty<double?>(); }
            set { SetProperty(value); }
        }

        public double? Longitude
        {
            get { return GetProperty<double?>(); }
            set { SetProperty(value); }
        }

        [InverseProperty(nameof(Person.AddressPerson))]
        public ObservableCollection<Person> Address_persons
        {
            get { return GetProperty<ObservableCollection<Person>>(); }
            protected set { SetProperty(value); }
        }

        [InverseProperty(nameof(Estate.AddressEstate))]
        public ObservableCollection<Estate> Address_estates
        {
            get { return GetProperty<ObservableCollection<Estate>>(); }
            protected set { SetProperty(value); }
        }
    }
}
