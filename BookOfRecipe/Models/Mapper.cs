using Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfRecipe.Models
{
    public static class Mapper
    {
        public static RecipeDTO RecipeMapping(RecipeVM vm)
        {
            var dto = new RecipeDTO();
            dto.Name = vm.Name;
            dto.Description = vm.Description;
            dto.ImagePath = vm.ImagePath;
            dto.Category=(Category)vm.Category;
            dto.IsActive = true;
            dto.Ingredients=vm.Ingredients.Select(x => IngredientMapping(x)).ToList();
            return dto;
        }
        public static IngredientDTO IngredientMapping(IngredientVM vm)
        {
            var dto = new IngredientDTO();
            dto.Name = vm.Name;
            dto.Qty = vm.Qty;
            dto.Price = vm.Price;
            dto.Category=(Category)vm.Category;
            dto.IsToping = vm.IsToping;
           
            return dto;
        }
    }
}
