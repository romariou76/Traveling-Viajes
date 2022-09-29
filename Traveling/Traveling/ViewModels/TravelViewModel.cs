using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Traveling.Models;
using Traveling.Views;
using Xamarin.Forms;

namespace Traveling.ViewModels
{
    public class TravelViewModel : BaseTravelViewModel
    {
        public Command LoadTravelCommand { get; }
        public ObservableCollection<TravelInfo> TravelInfos { get; }

        public Command AddTravelCommand { get; }

        public TravelViewModel()
        {
            LoadTravelCommand = new Command(async()=> await ExecuteLoadTravelCommand());
            TravelInfos = new ObservableCollection<TravelInfo>();
            AddTravelCommand = new Command(onAddTravel());
        }

        private Action<object> onAddTravel()
        {
            throw new NotImplementedException();
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        async Task ExecuteLoadTravelCommand()
        {
            IsBusy= true;

            try
            {
                TravelInfos.Clear();
                var travList = await App.TravelService.GetTravelAsync();
                foreach (var trav in travList)
                {
                    TravelInfos.Add(trav);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async void OnaddTravel(object obj)
        {
            await Shell.Current.GoToAsync(nameof(AddTravelPage));
        }
    }
}
