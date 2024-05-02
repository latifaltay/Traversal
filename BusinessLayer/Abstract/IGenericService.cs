using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        
    }
}
