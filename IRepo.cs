using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportManagementBLLibrary
{
    public interface IRepo<T>
    {
        void Add(T T);
        void Update(int id, T t);
        ICollection<T> GetAll();
        T Get(int id);
        void Delete(int id);
    }
}
