using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveling.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Traveling.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TravelPage : ContentPage
    {
        TravelViewModel travelViewModel;
        public TravelPage()
        {
            InitializeComponent();
            BindingContext = travelViewModel = new TravelViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            travelViewModel.OnAppearing();
        }
    }
}