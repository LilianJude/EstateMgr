using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstateMgrCore.Models
{
    public class Photos : ViewModels.BaseNotifyPropertyChanged
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

        public String Base64
        {
            get { return GetProperty<String>(); }
            set { SetProperty(value); }
        }

        public String Title
        {
            get { return GetProperty<String>(); }
            set { SetProperty(value); }
        }

        public DateTime ShootingDate
        {
            get { return GetProperty<DateTime>(); }
            set { SetProperty(value); }
        }

        [ForeignKey(nameof(EstateId))]
        public Estate EstatePhoto { get; set; }
    }
}
