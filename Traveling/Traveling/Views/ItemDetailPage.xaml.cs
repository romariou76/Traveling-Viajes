using System.ComponentModel;
using Traveling.ViewModels;
using Xamarin.Forms;

namespace Traveling.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}