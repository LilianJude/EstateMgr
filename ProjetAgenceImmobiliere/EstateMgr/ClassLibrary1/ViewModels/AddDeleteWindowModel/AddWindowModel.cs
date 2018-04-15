using EstateMgrCore.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace EstateMgrCore.ViewModels.AddDeleteWindowModel
{
    public class AddWindowModel : BaseNotifyPropertyChanged
    {
        public Estate NewEstate
        {
            get => GetProperty<Estate>();
            set
            {
                if (SetProperty(value))
                {
                    value.PropertyChanged += OnEstatePropertyChanged;
                }
            }
        }
        public Photos photo
        {
            get => GetProperty<Photos>();
            set => SetProperty(value);
        }
        public string ShowAddressText
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
        public string Error
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
        public string ShowOwnerText
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        private void OnEstatePropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Estate.AddressEstate))
            {
                 OnPropertyChanged(nameof(ShowAddressBtn));
                 OnPropertyChanged(nameof(ShowAddress));
            }
            if (e.PropertyName == nameof(Estate.Owner))
            { 
                OnPropertyChanged(nameof(ShowOwnerBtn));
                OnPropertyChanged(nameof(ShowOwner));
            }
        }
        public bool ShowAddressBtn
        {
            get => NewEstate?.AddressEstate == null;
        }
        public bool ShowAddress
        {
            get => !ShowAddressBtn;
        }
        public bool ShowOwnerBtn
        {
            get => NewEstate?.Owner == null;
        }
        public bool ShowOwner
        {
            get => !ShowOwnerBtn;
        }

        public ObservableCollection<string> Types
        {
            get { return GetProperty<ObservableCollection<string>>(); }
            set { SetProperty(value); }
        }
        public Person SelectedReferent
        {
            get { return GetProperty<Person>(); }
            set { SetProperty(value); }
        }
        public string SelectedType
        {
            get { return GetProperty<string>(); }
            set { SetProperty(value); }
        }
        public ObservableCollection<Person> Referents
        {
            get { return GetProperty<ObservableCollection<Person>>(); }
            private set { SetProperty(value); }
        }
        public Commande.BaseCommand<Type> OpenOwnerCommand
        {
            get => new Commande.BaseCommand<Type>(TView =>
            {
                AddOwnerWindowViewModel vm = new AddOwnerWindowViewModel();
                if (NavigationService.ShowDialog(TView, vm) == true)
                {
                    NewEstate.Owner = vm.CurrentOwner;
                    NewEstate.OwnerId = vm.CurrentOwner.Id;
                    NewEstate.AddressId = vm.CurrentOwner.AddressId;
                    Console.WriteLine(NewEstate.Owner.Name);
                    ShowOwnerText = NewEstate.Owner.FirstName + " " + NewEstate.Owner.Name;
                }
            });
        }
        public Commande.BaseCommand<Type> OpenPictureCommand
        {
            get => new Commande.BaseCommand<Type>((type) =>
            {
                OpenFileDialog op = new OpenFileDialog();
                op.DefaultExt = ".png";
                var result = op.ShowDialog();
                if (result == false) return;
                var picturePath = op.FileName;
                byte[] imageArray = System.IO.File.ReadAllBytes(picturePath);
                String base64Picture = Convert.ToBase64String(imageArray);
                photo.Base64 = base64Picture;
               
            });
        }
        public Commande.BaseCommand<Type> ValidateCommand
        {
            get => new Commande.BaseCommand<Type>((type) =>
            {
                NewEstate.ReferentId = SelectedReferent.Id;
                DataAccess.AgencyDbContext.Current.Estate.Add(NewEstate);
                DataAccess.AgencyDbContext.Current.SaveChanges();
                photo.EstateId = NewEstate.Id;
                DataAccess.AgencyDbContext.Current.Photos.Add(photo);
                Error = "Le bien a été ajouté à la base de données !";
            });
        }
        public AddWindowModel()
        {
            this.NewEstate = new Estate();
            this.photo = new Photos();
            this.Referents = new ObservableCollection<Person>(DataAccess.AgencyDbContext.Current.Person.Where(e => e.Referent == 1).ToArray());
            if(this.Referents.Count>0)
                this.SelectedReferent = this.Referents[0];
            this.Types = new ObservableCollection<string>
            {
            "Maison",
            "Appartement",
            "Terrain",
            "Garage",
            "Commerce"
            };
            this.SelectedType = this.Types[0];
        }
    }
}
