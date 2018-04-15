using System;
using System.Collections.Generic;
using System.Text;
using LiveCharts;
namespace EstateMgrCore.ViewModels
{
    public class GraphMonthViewModel<TLineSeries> : BaseNotifyPropertyChanged
        where TLineSeries : LiveCharts.Definitions.Series.ISeriesView, new()
    {
        public SeriesCollection MySeriesCollection { get => GetProperty<SeriesCollection>(); set => SetProperty(value); }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }


        public GraphMonthViewModel()
        {
            MySeriesCollection = new SeriesCollection
            {
                new TLineSeries
                {
                    Values = new ChartValues<double> {1,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,1,0,0,0,0,1,0,0,0,0,0,1,0,0}
                }

            };

            Labels = new[]
            {
                DateTime.Now.AddDays(-30).ToString("dd MMM"),
                DateTime.Now.AddDays(-29).ToString("dd MMM"),
                DateTime.Now.AddDays(-28).ToString("dd MMM"),
                DateTime.Now.AddDays(-27).ToString("dd MMM"),
                DateTime.Now.AddDays(-26).ToString("dd MMM"),
                DateTime.Now.AddDays(-25).ToString("dd MMM"),
                DateTime.Now.AddDays(-24).ToString("dd MMM"),
                DateTime.Now.AddDays(-23).ToString("dd MMM"),
                DateTime.Now.AddDays(-22).ToString("dd MMM"),
                DateTime.Now.AddDays(-21).ToString("dd MMM"),
                DateTime.Now.AddDays(-20).ToString("dd MMM"),
                DateTime.Now.AddDays(-19).ToString("dd MMM"),
                DateTime.Now.AddDays(-18).ToString("dd MMM"),
                DateTime.Now.AddDays(-17).ToString("dd MMM"),
                DateTime.Now.AddDays(-16).ToString("dd MMM"),
                DateTime.Now.AddDays(-15).ToString("dd MMM"),
                DateTime.Now.AddDays(-14).ToString("dd MMM"),
                DateTime.Now.AddDays(-13).ToString("dd MMM"),
                DateTime.Now.AddDays(-12).ToString("dd MMM"),
                DateTime.Now.AddDays(-11).ToString("dd MMM"),
                DateTime.Now.AddDays(-10).ToString("dd MMM"),
                DateTime.Now.AddDays(-9).ToString("dd MMM"),
                DateTime.Now.AddDays(-8).ToString("dd MMM"),
                DateTime.Now.AddDays(-7).ToString("dd MMM"),
                DateTime.Now.AddDays(-6).ToString("dd MMM"),
                DateTime.Now.AddDays(-5).ToString("dd MMM"),
                DateTime.Now.AddDays(-4).ToString("dd MMM"),
                DateTime.Now.AddDays(-3).ToString("dd MMM"),
                DateTime.Now.AddDays(-2).ToString("dd MMM"),
                DateTime.Now.AddDays(-1).ToString("dd MMM"),
                DateTime.Now.ToString("dd MMM"),
                };
        }



    }
}
