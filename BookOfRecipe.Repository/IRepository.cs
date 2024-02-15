using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfRecipe.Repository
{
    public interface IRepository<T>
    {
        Task Add(T entity);

        Task Delete(T entity);

        List<T> GetAll();

        Task Update (T entity);

        T GetById(int id);
    }
}
