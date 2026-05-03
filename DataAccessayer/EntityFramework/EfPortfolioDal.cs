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
    public class EfPortfolioDal : GenericRepository<Portfolio>, IPortfolioDal
    {
        public EfPortfolioDal(Context _context) : base(_context)
        {
        }
    }
}
