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
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureDal(Context _context) : base(_context)
        {
        }
    }
}
