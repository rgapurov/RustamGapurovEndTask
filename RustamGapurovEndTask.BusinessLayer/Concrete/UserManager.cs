using RustamGapurovEndTask.DataAccessLayer.Concrete;
using RustamGapurovEndTask.DataAccessLayer.Concrete.Repositories;
using RustamGapurovEndTask.EntityLayer.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustamGapurovEndTask.BusinessLayer.Concrete
{
    public class UserManager
    {
        private readonly Context _context;
        public UserManager()
        {
            _context = new Context();   
        }

        public bool Login(string email, string password)
        {
            var result = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public List<User> ListUser()
        {
            return _context.Users.ToList();
        }
    }
}
