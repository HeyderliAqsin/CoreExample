using Entities.Concrete;
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
        void Add(Product product);
        void Update(Product product);
        void Delete(int? id);
    }

}
