using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProduct(int? id);
        List<Product> GetSale();
        void Add(ProductDTO product);
        void Update(int id,ProductDTO product);
        void Delete(int? id);
    }

}
