using System;
using System.Diagnostics;
using DietMobileApp.Models;
using DietMobileApp.Services;
using Xamarin.Forms;

namespace DietMobileApp.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class NutrionalDetialViewModel : BaseViewModel
    {
        public IDataStore<Food> FoodStore => DependencyService.Get<IDataStore<Food>>();


        private string itemId;
        private string name;
        private string description;
        public string Id { get; set; }

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await FoodStore.GetItemAsync(itemId);
                Id = item.Id;
                Name = item.Name;
                Description = item.Description;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
