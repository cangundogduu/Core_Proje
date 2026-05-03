using DataAccessayer.Abstract;
using DataAccessayer.Concrete;
using DataAccessayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessayer.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
        public EfAboutDal(Context _context) : base(_context)
        {
        }
    }
}
