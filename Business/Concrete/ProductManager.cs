using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager:IProductService
    {
        IProductDal _dal;

        public ProductManager(IProductDal dal)
        {
            _dal = dal;
        }

        public void Add(Product product)
        {
            _dal.Add(product);
        }
        public void Delete(int? id)
        {
            if(id == null) return;
           var product= _dal.Get(c => c.Id == id);
           product.IsDeleted = true;
            _dal.Update(product);
        }

        public Product? GetProduct(int? id)
        {
            if(id==null) return null;
            return _dal.Get(c => c.Id == id);
        }


        //public List<Product> SearchProducts(int? categoryId,decimal? minPrice,decimal? maxPrice)
        //{
        //    return _dal.SearchProducts(categoryId,minPrice,maxPrice);
        //}

        public List<Product> GetProducts()
        {
            return _dal.GetAll(c => !c.IsDeleted);
        }

        public List<Product> GetSale()
        {
            return _dal.GetAll(c => c.Discount > 0 && c.Discount != null && !c.IsDeleted);
        }

        public void Update(Product product)
        {
            _dal.Update(product);
        }
    }
}
