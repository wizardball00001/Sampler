using System;
namespace MO
{
    public interface I_UserRepo
    {
        bool Add(MD.user AddUser);
        bool Remove(int userID);
        bool Save();
    }
}
