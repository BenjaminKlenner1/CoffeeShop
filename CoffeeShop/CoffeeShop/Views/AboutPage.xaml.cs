using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeeShop.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void OnClickInstagram(object sender, EventArgs e)
        {
            await Browser.OpenAsync("http://www.instagram.com/CoffeeOnLincoln", BrowserLaunchMode.SystemPreferred);
        }

        private async void OnClickFacebook(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://www.facebook.com/CoffeeOnLincoln", BrowserLaunchMode.SystemPreferred);
        
        }
    }
}