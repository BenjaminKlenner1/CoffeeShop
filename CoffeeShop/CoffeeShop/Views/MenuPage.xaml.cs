using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeeShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void Espresso_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EspressoPage());
        }

        private async void HotDrinks_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HotDrinksPage());
        }

        private async void ColdDrinks_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ColdDrinksPage());
        }

        private async void QuickBites_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuickBitesPage());
        }
        
   
    }
}