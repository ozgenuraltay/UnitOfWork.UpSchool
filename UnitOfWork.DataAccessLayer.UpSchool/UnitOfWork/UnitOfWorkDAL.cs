using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.DataAccessLayer.UpSchool.Concrete;

namespace UnitOfWork.DataAccessLayer.UpSchool.UnitOfWork
{
    public class UnitOfWorkDAL : IUnitOfWorkDAL
    {
        private readonly Context _context;

        public UnitOfWorkDAL(Context context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
