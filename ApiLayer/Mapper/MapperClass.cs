using ApiLayer.Models;
using AutoMapper;
using Domain.Product.DTO;

namespace ApiLayer.Mapper
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<ProductModel,ProductDTO>().ReverseMap();
        }   
    }
}