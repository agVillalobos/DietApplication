using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DietMobileApp.Models;

namespace DietMobileApp.Services
{
    public class FoodDataStore : IDataStore<Food>
    {
        private List<Food> foods;

        public FoodDataStore()
        {
            foods = new List<Food>()
            {
                new Food { Id = Guid.NewGuid().ToString(), Name = "Food 1", Description="This is an item description." },
                new Food { Id = Guid.NewGuid().ToString(), Name = "Food 2", Description="This is an item description." },
            };
        }

        public async Task<bool> AddItemAsync(Food item)
        {
            foods.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = foods.Where((Food arg) => arg.Id == id).FirstOrDefault();
            foods.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Food> GetItemAsync(string id)
        {
            return await Task.FromResult(foods.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Food>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(foods);
        }

        public async Task<bool> UpdateItemAsync(Food item)
        {
            var oldItem = foods.Where((Food arg) => arg.Id == item.Id).FirstOrDefault();
            foods.Remove(oldItem);
            foods.Add(item);

            return await Task.FromResult(true);
        }
    }
}
