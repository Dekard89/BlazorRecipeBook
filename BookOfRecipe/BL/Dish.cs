using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfRecipe.BL
{
    public class Dish
    {
        public string Name { get; set; } = "";

        public string Image { get; set; }

        public double Price { get; set; }

        public double TotalPrice 
        {
            get => TotalPrice;

            set => TotalPrice *= 1.7;
        }

        public string AppendName(string str) =>  $"{Name}\n с добавлением {str}";

        public double AppenPrice(double numb) => Price + numb;
    }
}
