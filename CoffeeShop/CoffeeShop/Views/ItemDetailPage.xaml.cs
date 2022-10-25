﻿using CoffeeShop.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CoffeeShop.Views
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