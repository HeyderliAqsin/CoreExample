using AutoMapper;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.MyProfiles
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductListDTO>()
                
                .ForMember(
                    dest => dest.CategoryName,
                    opt => opt.MapFrom(src => src.Category.CategoryRecords.FirstOrDefault().Name)
                )
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => src.ProductRecords.FirstOrDefault().Name)
                )
            .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(src => src.ProductRecords.FirstOrDefault().Description)
                );
        }
    }
}
