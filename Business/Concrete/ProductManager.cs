using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
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

        public void Add(ProductDTO product)
        {
            _dal.AddProductWithLang(product);
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
            return _dal.GetAllWithInclude();
        }

        public List<Product> GetSale()
        {
            return _dal.GetAll(c => c.Discount > 0 && c.Discount != null && !c.IsDeleted);
        }

        public void Update(int id,ProductDTO product)
        {
           Product selectedPro = _dal.Get(c=> c.Id == id);   
            selectedPro.Price=product.Price;
            selectedPro.Discount=product.Discount; 
            selectedPro.CategoryId=product.CategoryId;
            _dal.Update(selectedPro);
        }
    }
}
