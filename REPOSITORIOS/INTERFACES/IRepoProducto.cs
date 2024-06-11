using MODELOS.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORIOS.INTERFACES
{
    public interface IRepoProducto
    {
        Task<IEnumerable<Productos>> GetRandomProductos(int count);
    }
}
