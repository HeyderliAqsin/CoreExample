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
    public class CategoryManager:ICategoryService
    {
        ICategoryDal _dal;

        public CategoryManager(ICategoryDal dal)
        {
            _dal = dal;
        }

        public List<Category> GetCategories()
        {
            return _dal.GetAll(c=>!c.IsDeleted);
        }

        public Category? GetById(int? id)
        {
            if(id==null) return null;
            return _dal.Get(c => !c.IsDeleted && c.Id==id);
        }

        public void Add(Category category)
        {
            _dal.Add(category);
        }
        public void Update(Category category)
        {
            _dal.Update(category);
        }

        public void Delete(int? id)
        {
            if (id == null) return;
            var category = _dal.Get(c => c.Id == id);
            category.IsDeleted = true;
            _dal.Update(category);
        }
    }
}
