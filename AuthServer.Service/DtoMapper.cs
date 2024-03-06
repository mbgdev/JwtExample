using AutoMapper;
using AuthServer.Core.DTOs;
using AuthServer.Core.Models;

namespace AuthServer.Service
{
    public class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<UserAppDto, UserApp>().ReverseMap();
        }
    }
}