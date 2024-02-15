using Domain.Entitys;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfRecipe.Repository
{
    public class RecipeRepository : IRepository<RecipeDTO>
    {
        private readonly Context _context;

        public RecipeRepository(Context context)
        {
            _context = context;
        }

        public async Task Add(RecipeDTO entity)
        {
            await _context.Recipes.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(RecipeDTO entity)
        {
            _context.Recipes.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public List<RecipeDTO> GetAll()
        {
            return _context.Recipes.Where(x => x.IsActive == true).ToList();
        }

        public RecipeDTO GetById(int id)
        {
            var recipe = _context.Recipes.FirstOrDefault(x => x.Id == id);
            return recipe;
        }

        public async Task Update(RecipeDTO entity)
        {
            _context.Recipes.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
