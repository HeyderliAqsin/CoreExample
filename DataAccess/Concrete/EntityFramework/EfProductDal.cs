using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EFEntityRepositoryBase<Product, T110Context>, IProductDal
    {
        public List<Product> SearchProducts(int? categoryId, decimal? minPrice, decimal? maxPrice)
        {
            using T110Context context = new();
            var products = context.Products.AsQueryable();

            if (categoryId.HasValue)
            {
                products = products.Where(c => c.CategoryId == categoryId);
            }
            if (minPrice.HasValue && maxPrice.HasValue)
            {

                products = products.Where(c => (c.Discount != null && c.Discount > 0) ?
                (c.Discount >= minPrice && c.Discount <= maxPrice) :
                (c.Price >= minPrice && c.Price <= maxPrice)
                );
            }
            return products.ToList();

        }
    }
}
