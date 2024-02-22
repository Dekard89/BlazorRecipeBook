using BookOfRecipe.Models;
using BookOfRecipe.Repository;
using Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfRecipe.BL.Services
{
    public class RecipeService
    {
        private readonly IRepository<RecipeDTO> _repository;

        public List<RecipeVM> AllRecipes { get; set; }



        public RecipeService(IRepository<RecipeDTO> repository)
        {
                _repository=repository;
            AllRecipes = _repository.GetAll().Select(x => new RecipeVM(x)).ToList();
        }

        public RecipeVM Recipe { get; set; }

        public List<RecipeVM> GetAll()
        {
            var result= _repository.GetAll().Select(x=>new RecipeVM(x)).ToList();

            return result;
        }

        public void AddIngredient(IngredientVM ingredient)
        {
            Recipe.Ingredients.Add(ingredient);
           
        }
    }
}
