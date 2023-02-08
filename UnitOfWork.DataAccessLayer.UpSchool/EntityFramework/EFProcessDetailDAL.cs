using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.DataAccessLayer.UpSchool.Abstract;
using UnitOfWork.DataAccessLayer.UpSchool.Concrete;
using UnitOfWork.DataAccessLayer.UpSchool.Repository;
using UnitOfWork.EntityLayer.UpSchool.Concrete;

namespace UnitOfWork.DataAccessLayer.UpSchool.EntityFramework
{
    public class EFProcessDetailDAL : GenericRepository<ProcessDetail>, IProcessDetailDAL
    {
        public EFProcessDetailDAL(Context context) : base(context)
        {
        }
    }
}
