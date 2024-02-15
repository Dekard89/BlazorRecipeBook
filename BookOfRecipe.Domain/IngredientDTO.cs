using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfRecipe.Domain
{
    public class IngredientDTO
    {
        public int I { get; set; } = new int();

        public string Name { get; set; }

        public int Qty { get; set; }

        public double Price { get; set; }

        public Category Category { get; set; }

        public List<RecipeDTO> Recipes { get; set; } = new List<RecipeDTO>();
    }
}
