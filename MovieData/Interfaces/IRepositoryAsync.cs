using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieData.Interfaces
{
    public interface IRepositoryAsync<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task<List<T>> GetListAsync();
        Task<List<T>> Entities(Expression<Func<T, bool>> pre);
    }
}
