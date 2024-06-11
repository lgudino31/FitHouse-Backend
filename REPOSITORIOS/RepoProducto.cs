using DATA;
using Microsoft.EntityFrameworkCore;
using MODELOS.ENTIDADES;
using REPOSITORIOS.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORIOS
{
    public class RepoProducto: IRepoProducto
    {
        private readonly AppDbContext _dbcontext;
        private readonly DbSet<Productos> _dbSet;

        public RepoProducto(AppDbContext context)
        {
            _dbcontext = context;
            _dbSet = context.Set<Productos>();
        }
        public async Task<IEnumerable<Productos>> GetRandomProductos(int count)
        {
            return await _dbSet.OrderBy(p => Guid.NewGuid()).Take(count).ToListAsync();
        }
    }
   
      
}
