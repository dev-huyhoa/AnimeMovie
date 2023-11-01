using Microsoft.EntityFrameworkCore;
using MovieContext.Model.Movie;
using MovieData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieData.Repositories
{
    public class RepositoryAsync<T> : IRepositoryAsync<T> where T : class
    {
        private readonly MovieAnimeContext _context;

        public RepositoryAsync(MovieAnimeContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public Task<List<T>> Entities(Expression<Func<T, bool>> pre)
        {
            return _context.Set<T>().Where(pre).ToListAsync();
        }

        public async Task<List<T>> GetListAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}
