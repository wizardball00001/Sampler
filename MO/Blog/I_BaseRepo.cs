using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MO
{
    public interface I_BaseRepo<T>
    {
        T GetByID(int ID);

        List<T> GetAll();

        bool Add(T add);

        bool RemoveByID(int ID);

        bool Update(int ID, T update);

        bool SaveTheChanges();


    }
}
