using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MODELOS.DTOS;
using MODELOS.ENTIDADES;
using SERVICIOS.Interfaces;

namespace FitHouseV2.Controllers
{
    [Route("api/[ControllerProducto]")]
    [ApiController]

    public class ProductoController : ControllerBase
    {
        private readonly IProductoServicio _IproductoServicio;
        

        public ProductoController(IProductoServicio productoService)
        {
            _IproductoServicio = productoService;
           
        }
        [HttpGet("/")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IEnumerable<ProductoDtos>> GetAllRecomendados()
        {
            try
            {
                
                var ProductosList = await _IproductoServicio.ProductoRecomendado(10);
                return ProductosList;
            }
            catch (Exception ex)
            {
                
                throw;
            }

        }

    }
}
