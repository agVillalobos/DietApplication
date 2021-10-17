using System;
using System.Collections.Generic;
using DietMobileApp.ViewModels;
using Xamarin.Forms;

namespace DietMobileApp.Views
{
    public partial class NutrionalListView : ContentPage
    {
        NutrionalListViewModel _viewModel;
        public NutrionalListView()
        {
            InitializeComponent();
            BindingContext = _viewModel = new NutrionalListViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}
