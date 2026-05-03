using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

        List<T> GetAll();

    }
}
