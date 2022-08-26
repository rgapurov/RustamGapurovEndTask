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
            if (p.Name == "" || p.Name.Length < 4)
            {
                //hata mesajı
            }
            else
            {
                _category.Insert(p);
            }
        }

    }
}
