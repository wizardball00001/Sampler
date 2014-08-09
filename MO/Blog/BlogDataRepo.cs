using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MO
{
    public class BlogDataRepo : I_BlogDataRepo
    {
        public MD.MVCEntities da = new MD.MVCEntities();


        public MD.BlogData GetByID(int ID)
        {
            return da.BlogDatas.Where(m => m.ID == ID).FirstOrDefault();
        }

        public List<MD.BlogData> GetAll()
        {
            return da.BlogDatas.Where(m => m.ID == m.ID).ToList();
        }

        public bool Add(MD.BlogData add)
        {
            var dax = new MD.MVCEntities();
            dax.BlogDatas.Add(add);
            dax.SaveChanges();
            //da.BlogDatas.Add(add);
            return true;
        }

        public bool RemoveByID(int ID)
        {
            var foo = da.BlogDatas.Where(m => m.ID == ID).FirstOrDefault();
            da.BlogDatas.Remove(foo);
            return true;

        }

        public bool Update(int ID, MD.BlogData update)
        {
            var foo = da.BlogDatas.Where(m => m.ID == ID).FirstOrDefault();
            foo = update;
            return true;
        }

        public bool SaveTheChanges()
        {
            da.SaveChanges();
            return true;
        }
    }
}
