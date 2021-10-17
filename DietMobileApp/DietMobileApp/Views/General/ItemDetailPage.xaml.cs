using System.ComponentModel;
using Xamarin.Forms;
using DietMobileApp.ViewModels;

namespace DietMobileApp.Views
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
