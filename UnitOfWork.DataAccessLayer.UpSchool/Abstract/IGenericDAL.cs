using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.DataAccessLayer.UpSchool.Abstract
{
    public interface IGenericDAL<T> where T:class
    {
        void Insert(T t);

        void Delete(T t);

        void Update(T t);

        List<T> GetList();

        T GetByID(int id);

        void MultiUpdate(List<T> t);
    }
}
