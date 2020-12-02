using DNP_Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNP_Assignment3.Data
{
    public class UserLogin : IUserLogin
    {
        public async Task<User> ValidateUser(string username)
        {
            using (DataContext dataContext = new DataContext())
            {
                foreach (User user in dataContext.Users)
                {
                    if (user.UserName.Equals(username))
                    {
                        return user;
                    }
                }

                return null;

            }
        }
    }
}
