using FluentValidation.Results;
using RustamGapurovEndTask.BusinessLayer.ValidationRules;
using RustamGapurovEndTask.DataAccessLayer.Concrete.Repositories;
using RustamGapurovEndTask.EntityLayer.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustamGapurovEndTask.BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> _category = new GenericRepository<Category>();
        
        public List<Category> GetAll()
        {
            return _category.List();
        }
        public void CategoryAdd(Category p)
        {
            _category.Insert(p);
        }
        public void CategoryDelete(Category p)
        {
            _category.Delete(p);
        }
        public void CategoryUpdate(Category p)
        {
            _category.Update(p);
        }
        public Category GetByIdCategory(int id)
        {
            return _category.Get(x => x.Id == id);
        }
    }
}
