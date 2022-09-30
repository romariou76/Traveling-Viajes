using System;
using System.Collections.Generic;
using System.Text;
using Traveling.Models;
using Xamarin.Forms;

namespace Traveling.ViewModels
{
    public class AddTravelViewModel:BaseTravelViewModel
    {
        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        public AddTravelViewModel()
        {
            SaveCommand = new Command(OnSave);
            CancelCommand = new Command(OnCancel);

            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
            TravelInfo = new TravelInfo();
        }

        private async void OnSave()
        {
            var travel = TravelInfo;
            await App.TravelService.AddTravelAsync(travel);

            await Shell.Current.GoToAsync("..");
        }

        private async void OnCancel()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
