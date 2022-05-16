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
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.Id)
                )
                .ForMember(
                    dest => dest.Discount,
                    opt => opt.MapFrom(src => src.Discount)
                )
                .ForMember(
                    dest => dest.Price,
                    opt => opt.MapFrom(src => src.Price)
                )
                .ForMember(
                    dest => dest.CategoryId,
                    opt => opt.MapFrom(src => src.CategoryId)
                )
                .ForMember(
                    dest => dest.CategoryName,
                    opt => opt.MapFrom(src => src.Category.CategoryRecords.FirstOrDefault().Name)
                )
                .ForMember(
                    dest => dest.ProductRecords,
                    opt => opt.MapFrom(src => src.ProductRecords.FirstOrDefault())
                );
        }
    }
}
