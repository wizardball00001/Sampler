using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MO
{
    public class UserRepo : MO.I_UserRepo, MO.IUserRepo
    {
        //MD.MVCEntities da = new MD.MVCEntities();
        private MD.MVCEntities da;

        public UserRepo() {
            da = new MD.MVCEntities();
        }
        
        public bool Add(MD.user AddUser) {
            da.users.Add(AddUser);
            return true;
        }


        public bool Remove(int userID) {

            var user = da.users.FirstOrDefault(q => q.id == userID);
            da.users.Remove(user);
            return true;

        }

        public bool Save() {
            if (da.SaveChanges() == 1)
            {
                return true;
            }

            return false;
            
        }

        public List<MD.user> GetAll() {

            return da.users.ToList();

        }
    }
}
