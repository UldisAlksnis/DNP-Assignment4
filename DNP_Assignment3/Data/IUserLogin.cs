using DNP_Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNP_Assignment3.Data
{
    public interface IUserLogin
    {
        Task<User> ValidateUser(string userName);
    }
}
