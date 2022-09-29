using System;
using System.IO;
using Traveling.Services;
using Traveling.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Traveling
{
    public partial class App : Application
    {
        static TravelService _travelService;
        public static TravelService TravelService
        {
            get
            {
                if (_travelService == null)
                {
                    _travelService = new TravelService(Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Traveling.db3"));
                }
                return _travelService;
            }
        }
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
