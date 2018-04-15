using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstateMgrCore.ViewModels
{
    public class CurrentEstateOnSaleViewModel : BaseNotifyPropertyChanged
    {

        public string nbreBienEnVente { get; set; }
        public CurrentEstateOnSaleViewModel()
        {

            Array list = DataAccess.AgencyDbContext.Current.Estate.ToArray();
            nbreBienEnVente = list.Length.ToString();
        }

    }
}
