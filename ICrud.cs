using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApp49
{
   public interface ICrud
    {
        string AddUser(User user);
        string DeleteUser(User user);
        string FindUserNameByID(int userID);
        string UpdateUser(string newUserName, int userID);
    }
}
