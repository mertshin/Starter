using AutoMapper;     // DTO'ların namespace'i
using Core.Entities;    // Entitylerin namespace'i

namespace Business.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Örnek mapping: Entity -> DTO ve DTO -> Entity
            //CreateMap<Product, ProductDto>().ReverseMap();
            //CreateMap<Category, CategoryDto>().ReverseMap();

            // Buraya diğer entity <-> DTO maplemelerini ekleyebilirsin
        }
    }
}
