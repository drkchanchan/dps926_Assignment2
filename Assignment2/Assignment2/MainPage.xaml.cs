using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Assignment2
{
    public partial class MainPage : ContentPage
    {

        ObservableCollection<Business> restaurants;

        public MainPage()
        {
            InitializeComponent();


        }

        protected async override void OnAppearing()
        {
            restaurants = await DatabaseManager.CreateTable();

            base.OnAppearing();
        }

        private async void Button_Search(object sender, EventArgs e)
        {
            string CityName = CityData.Text;
            string ProvinceName = ProvinceData.Text;
            string FoodName = FoodData.Text;

            restaurants = new ObservableCollection<Business>(await NetworkingManager.GetRestaurants(CityName, ProvinceName, FoodName));
            await Navigation.PushAsync(new ResultsPage(restaurants));
        }

        private async void Button_Saved(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SavedRestaurantsPage());
        }
    }
}
