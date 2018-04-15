using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstateMgrCore.Models
{
    public class RentTransaction : ViewModels.BaseNotifyPropertyChanged
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionId
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        public double Price
        {
            get { return GetProperty<double>(); }
            set { SetProperty(value); }
        }

        public double Fees
        {
            get { return GetProperty<double>(); }
            set { SetProperty(value); }
        }

        [ForeignKey(nameof(TransactionId))]
        public Transaction Transaction { get; set; }
    }
}
