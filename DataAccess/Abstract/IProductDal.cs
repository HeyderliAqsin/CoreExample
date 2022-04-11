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
        List<Product> GetAllWithInclude(Expression<Func<Product, bool>>? filters);
        List<Product> SearchProducts(int? categoryId,decimal? minPrice,decimal? maxPrice);
        void AddProductWithLang(ProductDTO productDTO);
    }
}
