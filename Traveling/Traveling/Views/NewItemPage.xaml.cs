using System;
using System.Collections.Generic;
using System.ComponentModel;
using Traveling.Models;
using Traveling.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Traveling.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}