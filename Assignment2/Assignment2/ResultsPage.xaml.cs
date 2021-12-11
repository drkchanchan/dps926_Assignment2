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
    public partial class ResultsPage : ContentPage
    {

        public ResultsPage(ObservableCollection<Business> businesses)
        {
            InitializeComponent();
            UIResults.ItemsSource = businesses;
        }

        async void UIResults_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            bool response = await DisplayAlert("Save Selected Restaurant", "Would you like to save this Restaurant?", "Yes", "No");

            if (response)
            {
                DatabaseManager.InsertSavedRestaurant(e.SelectedItem as Business);
                await DisplayAlert("Restaurant Saved", "The restaurant has been saved","OK");
            }
        }
    }
}