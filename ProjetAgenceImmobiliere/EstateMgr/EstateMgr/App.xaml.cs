using EstateMgrCore.ViewModels;
using EstateMgrCore.ViewModels.HomeWindowModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EstateMgr
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected async override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            await EstateMgrCore.DataAccess.AgencyDbContext.Initialize();
            MainWindow = (Window)EstateMgrCore.NavigationService.GetView<MainWindowViewModel<HomeWindowModel<GraphYearViewModel<LiveCharts.Wpf.ColumnSeries>, LiveCharts.Wpf.ColumnSeries>, LiveCharts.Wpf.ColumnSeries>> (typeof(MainWindow), typeof(HomeWindow), typeof(YearGraph));
            MainWindow.Show();
        }
    }
}
