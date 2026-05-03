using BusinessLayer.Abstract;
using DataAccessayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager(IAboutDal _aboutDal) : IAboutService
    {
        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public About TGetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public List<About> TGetList()
        {
          return  _aboutDal.GetAll();
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
