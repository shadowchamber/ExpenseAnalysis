using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpenseAnalysis
{
    public partial class App : Application
    {
        private static DataService _dataService;

        public static DataService DataService => _dataService ?? (_dataService = new DataService());

        public App()
        {
            MainPage = new MasterDetail();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
