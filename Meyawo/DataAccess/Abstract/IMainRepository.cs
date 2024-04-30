using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meyawo.DataAccess.Abstract
{
    public interface IMainRepository<T>  where T : class
    {
        void Add(T entity);
        List<T> GetAll();
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
    }
}
