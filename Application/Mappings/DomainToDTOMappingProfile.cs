using AutoMapper;
using Ecommerce.Application.DTOs;

namespace Ecommerce.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<CategoryDTO, CategoryDTO>().ReverseMap();
            CreateMap<ProductDTO, ProductDTO>().ReverseMap();
        }
    }
}
