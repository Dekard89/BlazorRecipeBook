using Domain.Entitys;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfRecipe.Repository
{
     public class TopingRepository : IRepository<TopingDTO>
    {
        private readonly Context _context;

        public TopingRepository(Context context)
        {
            _context = context;
        }
        public async Task Add(TopingDTO entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(TopingDTO entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public List<TopingDTO> GetAll()
        {
            return _context.Topings.ToList();
        }

        public TopingDTO GetById(int id)
        {
            var result = _context.Topings.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public async Task Update(TopingDTO entity)
        {
            _context.Topings.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
