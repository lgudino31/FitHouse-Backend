using MODELOS.ENTIDADES;
using SERVICIOS.Interfaces;
using REPOSITORIOS.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REPOSITORIOS;
using AutoMapper;
using MODELOS.DTOS;



namespace SERVICIOS
{
    public class ProductoServicio: IProductoServicio
    {
        private readonly IRepoProducto _IRepoProducto;
        private readonly IMapper _mapper;

        public ProductoServicio(IRepoProducto iRepoProducto, IMapper mapper)
        {
            _IRepoProducto = iRepoProducto;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductoDtos>> ProductoRecomendado(int count)
        {
            var recomendados =  await _IRepoProducto.GetRandomProductos(count);
            return _mapper.Map<IEnumerable<ProductoDtos>>(recomendados);
        }

    }
}
