using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.BusisnessLayer.UpSchool.Abstract;
using UnitOfWork.DataAccessLayer.UpSchool.Abstract;
using UnitOfWork.DataAccessLayer.UpSchool.UnitOfWork;
using UnitOfWork.EntityLayer.UpSchool.Concrete;

namespace UnitOfWork.BusisnessLayer.UpSchool.Concrete
{
    public class ProcessDetailManager : IProcessDetailService
    {
        private readonly IProcessDetailDAL _processDetailDAL;
        private readonly IUnitOfWorkDAL _unitOfWorkDAL;

        public ProcessDetailManager(IUnitOfWorkDAL unitOfWorkDAL, IProcessDetailDAL processDetailDAL)
        {
            _unitOfWorkDAL = unitOfWorkDAL;
            _processDetailDAL = processDetailDAL;
        }

        public void TDelete(ProcessDetail t)
        {
            _processDetailDAL.Delete(t);
            _unitOfWorkDAL.Save();
        }

        public ProcessDetail TGetByID(int id)
        {
            return _processDetailDAL.GetByID(id);
        }

        public List<ProcessDetail> TGetList()
        {
            return _processDetailDAL.GetList();
        }

        public void TInsert(ProcessDetail t)
        {
            _processDetailDAL.Insert(t);
            _unitOfWorkDAL.Save();
        }

        public void TMultiUpdate(List<ProcessDetail> t)
        {
            _processDetailDAL.MultiUpdate(t);
            _unitOfWorkDAL.Save();
        }

        public void TUpdate(ProcessDetail t)
        {
            _processDetailDAL.Update(t);
            _unitOfWorkDAL.Save();
        }
    }
}
