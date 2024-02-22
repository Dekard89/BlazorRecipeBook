using BookOfRecipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfRecipe.BL.Builder
{
    internal class DishBuilder : IDishBuilder
    {
        public RecipeVM Recipe {  get; set; }

        private readonly Dish _dish;


        public IDishBuilder AppendSecondToping()
        {
            _dish.AppendName(Recipe.Topings[1].Name);
            _dish.AppenPrice(Recipe.Topings[1].Price);
            return this;
        }

        public IDishBuilder AppendThirdToping()
        {
            _dish.AppendName(Recipe.Topings[2].Name);
            _dish.AppenPrice(Recipe.Topings[2].Price);
            return this;
        }

        public IDishBuilder AppenFirstToping()
        {
            _dish.AppendName(Recipe.Topings[0].Name);
            _dish.AppenPrice(Recipe.Topings[0].Price);
            return this;
        }

        public IDishBuilder BuidMain()
        {
            
            _dish.AppendName(Recipe.Name);
            _dish.Image = Recipe.ImagePath;
            return this;

        }

        public IDishBuilder BuidPrice()
        {
            _dish.Price=Recipe.Ingredients.Sum(x => x.Price);
            return this;
        }

        public Dish GetDish()=>_dish;
       
    }
}
