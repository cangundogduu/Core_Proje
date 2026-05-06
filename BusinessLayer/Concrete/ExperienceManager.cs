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
    public class ExperienceManager(IExperienceDal _experienceDal) : IExperienceService
    {
        public void TAdd(Experience t)
        {
            _experienceDal.Insert(t);   
        }

        public void TDelete(Experience t)
        {
            _experienceDal.Delete(t);   
        }

        public Experience TGetById(int id)
        {
           return _experienceDal.GetById(id);
        }

        public List<Experience> TGetList()
        {
            return _experienceDal.GetAll();
        }

        public void TUpdate(Experience t)
        {
            _experienceDal.Update(t);
        }
    }
}
