using Meyawo.DataAccess.Abstract;
using Meyawo.DataAccess.SqlDbContex;
using Meyawo.Entities.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meyawo.DataAccess.Concret
{
    public class UserRepository : IUserRepository
    {
        private MeyawoManagmentDbContex _dbContex = new();
        public void Add(User entity)
        {
            _dbContex.Users.Add(entity);
            _dbContex.SaveChanges();
        }

        public void Delete(User entity)
        {
            _dbContex.Users.Update(entity);
            _dbContex.SaveChanges();
        }

        public List<User> GetAll()
        {
           List<User> users =  _dbContex.Users.ToList();
            return users;
        }

        public User GetById(int id)
        {
            User user = _dbContex.Users.Find(id);
            return user;
        }

        public void Update(User entity)
        {
            _dbContex.Users.Update(entity);
            _dbContex.SaveChanges();
        }
    }
}
