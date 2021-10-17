using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using DietMobileApp.Models;
using DietMobileApp.Services;
using DietMobileApp.Views;
using Xamarin.Forms;

namespace DietMobileApp.ViewModels
{
    public class NutrionalListViewModel : BaseViewModel
    {
        private Food _selectedItem;
        public IDataStore<Food> FoodStore => DependencyService.Get<IDataStore<Food>>();


        public ObservableCollection<Food> Foods { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<Food> ItemTapped { get; }

        public NutrionalListViewModel()
        {
            Title = "Browse";
            Foods = new ObservableCollection<Food>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ItemTapped = new Command<Food>(OnItemSelected);

            AddItemCommand = new Command(OnAddItem);
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Foods.Clear();
                var items = await FoodStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Foods.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public Food SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        private async void OnAddItem(object obj)
        {
            //await Shell.Current.GoToAsync(nameof(NewItemPage));
        }

        async void OnItemSelected(Food item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(NutrionalDetailView)}?{nameof(NutrionalDetialViewModel.ItemId)}={item.Id}");
        }
    }
}
