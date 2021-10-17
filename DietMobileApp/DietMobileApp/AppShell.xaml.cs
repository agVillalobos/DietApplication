using System;
using System.Collections.Generic;
using DietMobileApp.ViewModels;
using DietMobileApp.Views;
using Xamarin.Forms;

namespace DietMobileApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
