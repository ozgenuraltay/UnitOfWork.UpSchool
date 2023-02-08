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
    public class AccountManager : IAccountService
    {
        private readonly IAccountDAL _accountDAL;
        private readonly IUnitOfWorkDAL _unitOfWorkDAL;

        public AccountManager(IUnitOfWorkDAL unitOfWorkDAL, IAccountDAL accountDAL)
        {
            _unitOfWorkDAL = unitOfWorkDAL;
            _accountDAL = accountDAL;
        }

        public void TDelete(Account t)
        {
            _accountDAL.Delete(t);
            _unitOfWorkDAL.Save();
        }

        public Account TGetByID(int id)
        {
            return _accountDAL.GetByID(id);
        }

        public List<Account> TGetList()
        {
            return _accountDAL.GetList();
        }

        public void TInsert(Account t)
        {
            _accountDAL.Insert(t);
            _unitOfWorkDAL.Save();
        }

        public void TMultiUpdate(List<Account> t)
        {
            _accountDAL.MultiUpdate(t);
            _unitOfWorkDAL.Save();
        }

        public void TUpdate(Account t)
        {
            _accountDAL.Update(t);
            _unitOfWorkDAL.Save();
        }
    }
}
