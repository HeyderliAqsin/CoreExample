using Core.DataAccess;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        Task<List<Product>> GetAllWithInclude(Expression<Func<Product, bool>>? filters,string lang);
        Product GetByIdWithInclude(Expression<Func<Product, bool>>? filters,string lang);
        Task<List<Product>> SearchProducts(string? searchTerm,string langKey);
        void AddProductWithLang(ProductDTO productDTO);
    }
}
