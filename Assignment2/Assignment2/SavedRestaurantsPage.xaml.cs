using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SavedRestaurantsPage : ContentPage
    {
        public SavedRestaurantsPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {

            //savedResults = 
            RestaurantDetails.ItemsSource = await DatabaseManager.CreateTable();
            base.OnAppearing();
        }

        async void itemDelete(object sender, EventArgs e)
        {
            
                DatabaseManager.DeleteSavedRestaurant((sender as MenuItem).CommandParameter as Business);
                await DisplayAlert("Restaurant Deleted", "The restaurant has been removed from your saved list", "OK");

                RestaurantDetails.ItemsSource = await DatabaseManager.CreateTable();
            
        }
    }
}