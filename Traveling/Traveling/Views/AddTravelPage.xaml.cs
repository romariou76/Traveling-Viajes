using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveling.Models;
using Traveling.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Traveling.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddTravelPage : ContentPage
    {
        public TravelInfo TravelInfo { get; set; }
        public AddTravelPage()
        {
            InitializeComponent();
            BindingContext = new AddTravelViewModel();
        }
    }
}