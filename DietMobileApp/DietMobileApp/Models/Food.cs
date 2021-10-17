using System;
namespace DietMobileApp.Models
{
    public class Food
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Proteins { get; set; }
        public double Fat { get; set; }
        public double Carbs { get; set; }
        public double Calories { get; set; }
    }
}
