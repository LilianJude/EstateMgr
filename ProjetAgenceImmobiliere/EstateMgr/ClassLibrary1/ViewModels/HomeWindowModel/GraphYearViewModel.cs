using System;
using System.Collections.Generic;
using System.Text;
using LiveCharts;
namespace EstateMgrCore.ViewModels
{
    public class GraphYearViewModel<TColumnSeries> : BaseNotifyPropertyChanged
        where TColumnSeries : LiveCharts.Definitions.Series.ISeriesView, new()
    {
        public SeriesCollection MySeriesCollection { get => GetProperty<SeriesCollection>(); set => SetProperty(value); }
         public string[] Labels { get; set; }
         public Func<double, string> Formatter { get; set; }
         public GraphYearViewModel()
         {
            MySeriesCollection = new SeriesCollection
             {
                 new TColumnSeries
                 {
                     //Title = "2017",
                     Values = new ChartValues<double> { 5,2,3,4,5,8,12,7,1,8,11,4 },
                 }
             };

             Labels = new[] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
             Formatter = value => value.ToString("N");
         }

      
    
    }
}
