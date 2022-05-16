using AutoMapper;
using Domain.Core.Models;
using Infraestructure.Data.AccessData;

namespace Infraestructure.Data.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Tbl_Ordenes, OrdenesDTO>().ReverseMap();
            CreateMap<tbl_OrdenesDetails, OrdenesDetailsDTO>().ReverseMap();
            CreateMap<tbl_Clientes, ClientesDTO>().ReverseMap();
            CreateMap<tbl_Productos, ProductosDTO>().ReverseMap();
            CreateMap<tbl_Users, UsersDTO>().ReverseMap();
        }
    }
}
