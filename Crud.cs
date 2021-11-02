using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionApp50
{
    public class Crud : ICrud
    {
        private UserContext _userContext = new UserContext();


        public string AddUser(User user)
        {
            _userContext.Users.Add(user);
            _userContext.SaveChangesAsync();
            return $"{user.UserName} was added";
        }

        public string DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public string FindUserNameByID(int userID)
        {
            string userName = _userContext.Users.Where(a => a.UserID == userID).FirstOrDefault()?.UserName;
            if (userName is null)
            {
                return $"No user was found with id:  {userID}";
            }
            return userName;
        }

        public string UpdateUser(string newUserName, int userID)
        {
            User user = _userContext.Users.Where(a => a.UserID == userID).FirstOrDefault();
            if (user is null)
            {
                return $"No user was found with id:  {userID}";
            }
            var oldName = user.UserName;
            user.UserName = newUserName;
            _userContext.SaveChanges();
            return $"{oldName} has been updated to {newUserName}";
        }
    }
}
