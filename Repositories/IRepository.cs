using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactApplication.Models
{
   public interface IRepository<T>
    {
        bool Add(T sObj);
        IEnumerable<T> Get();
        T Show(int Id);
        bool UpDate(int Id, T sObj);
        bool Delete(int Id);
    }
}