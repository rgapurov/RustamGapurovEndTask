using RustamGapurovEndTask.DataAccessLayer.Concrete.Repositories;
using RustamGapurovEndTask.EntityLayer.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustamGapurovEndTask.BusinessLayer.Concrete
{
    public class ProductManager
    {
        GenericRepository<Product> _product = new GenericRepository<Product>();
        public List<Product> ListProduct()
        {
            return _product.List();
        }

        public void AddProduct(Product product)
        {
            _product.Insert(product);
        }

        public void DeleteProduct(Product product)
        {
            _product.Delete(product);
            
        }
    }
}
