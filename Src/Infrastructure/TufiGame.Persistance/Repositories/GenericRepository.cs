using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TufiGame.Application.Interfaces.Repository;
using TufiGame.Domain.Common;
using TufiGame.Persistance.Context;

namespace TufiGame.Persistance.Repositories
{
    public class GenericRepository<T> : IGenericRepositoryAsync<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _dbContext;
        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _dbContext.Set<T>().Where(e => e.Id == id).ExecuteDeleteAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
            
        }

        public async Task<T> GetByIdAsync(Guid Id)
        {
            return await _dbContext.Set<T>().FindAsync(Id);
        }

        public async Task<T> UpdateAsync(T entity) //Bak
        {
            var existingEntity = await _dbContext.Set<T>().FindAsync(entity.Id);

            if (existingEntity == null)
                throw new Exception("Entity not found");
            _dbContext.Entry(existingEntity).CurrentValues.SetValues(entity);

            await _dbContext.SaveChangesAsync();
            return existingEntity;
        }

    }
}
