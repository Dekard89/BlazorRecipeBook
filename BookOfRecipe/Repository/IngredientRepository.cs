using Domain.Entitys;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfRecipe.Repository
{
    public class IngredientRepository : IRepository<IngredientDTO>
    {
        private readonly Context _context;

        public IngredientRepository(Context context)
        {
            _context = context;
        }
        public async Task Add(IngredientDTO entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(IngredientDTO entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public List<IngredientDTO> GetAll()
        {
            return _context.ingredients.ToList();
        }

        public IngredientDTO GetById(int id)
        {
            var ingredient = _context.ingredients.FirstOrDefault(x => x.Id == id);
            return ingredient;

        }

        public async Task Update(IngredientDTO entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
