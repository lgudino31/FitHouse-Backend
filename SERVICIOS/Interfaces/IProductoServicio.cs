using MODELOS.DTOS;
using MODELOS.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS.Interfaces
{
    public interface IProductoServicio
    {
        Task<IEnumerable<ProductoDtos>> ProductoRecomendado(int count);
    }
}
