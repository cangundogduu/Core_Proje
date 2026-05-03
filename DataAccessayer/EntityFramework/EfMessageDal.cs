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
    public class EfMessageDal : GenericRepository<Message>, IMessageDal
    {
        public EfMessageDal(Context _context) : base(_context)
        {
        }
    }
}
