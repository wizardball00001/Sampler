using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MO
{
    public class BlogUserRepo : I_BlogUserRepo
    {
        public MD.MVCEntities da = new MD.MVCEntities();
        public MD.BlogUser GetByID(int ID)
        {
            return da.BlogUsers.SingleOrDefault(m => m.ID == ID);
        }

        public List<MD.BlogUser> GetAll()
        {
            return da.BlogUsers.Where(m => m.ID == m.ID).ToList();
        }

        public bool Add(MD.BlogUser add)
        {
            da.BlogUsers.Add(add);
            return true;
        }

        public bool RemoveByID(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Update(int ID, MD.BlogUser update)
        {
            var foo = da.BlogUsers.SingleOrDefault(m => m.ID == ID);
            update = foo;
            return true;

        }

        public bool SaveTheChanges()
        {
            da.SaveChanges();
            return true;
        }



        public MD.BlogUser GetBlogger(string username, string password)
        {
            return da.BlogUsers.Where(m => m.Username == username & m.Password == password).FirstOrDefault();
        }
    }
}
