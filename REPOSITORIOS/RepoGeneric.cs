using DATA;
using Microsoft.EntityFrameworkCore;
using REPOSITORIOS.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORIOS
{
    public class RepoGeneric<TModels> : IRepoGeneric<TModels> where TModels : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<TModels> _dbSet;
        public RepoGeneric(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TModels>();
        }

        public async Task<IEnumerable<TModels>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        //public async Task<TModels> GetById(int id)
        //{
        //    return await _dbSet.FindAsync(id);
        //}

        //public async Task Add(TModels entity)
        //{
        //    await _dbSet.AddAsync(entity);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task Update(TModels entity)
        //{
        //    _dbSet.Attach(entity);
        //    _context.Entry(entity).State = EntityState.Modified;
        //    await _context.SaveChangesAsync();
        //}

        //public async Task Delete(int id)
        //{
        //    var entity = await _dbSet.FindAsync(id);
        //    if (entity != null)
        //    {
        //        _dbSet.Remove(entity);
        //        await _context.SaveChangesAsync();
        //    }
        }
}
