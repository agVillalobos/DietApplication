using System;
using System.Collections.Generic;
using DietMobileApp.ViewModels;
using Xamarin.Forms;

namespace DietMobileApp.Views
{
    public partial class NutrionalDetailView : ContentPage
    {
        NutrionalDetialViewModel _viewModel;
        public NutrionalDetailView()
        {
            InitializeComponent();
            BindingContext = _viewModel = new NutrionalDetialViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //_viewModel.OnAppearing();
        }
    }
}
