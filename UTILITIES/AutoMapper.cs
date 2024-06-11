using AutoMapper;
using MODELOS.DTOS;
using MODELOS.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTILITIES
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region Producto
            //CreateMap<Productos, ProductoDtos>().ForMember(dest => dest.Precio, opt => opt.MapFrom(origen => origen.Precio));
            //CreateMap<ProductoDtos, Productos>().ForMember(dest => dest.Precio, opt => opt.MapFrom(origen => origen.Precio));
            CreateMap<Productos, ProductoDtos>().ReverseMap();
            
            #endregion
        }
    }
}
