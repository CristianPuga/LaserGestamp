using LaserCutting.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaserCutting.Application
{
    public class TokenRepository : ITokenRepository
    {
        public User Authenticate(string username, string password)
        {
            try
            {
                var user = new User()
                {
                    Username = "Gestamp",
                    Password = "Gestamp2020"
                };

                if (username == user.Username && password == user.Password)
                {
                    Console.WriteLine(user);
                    return user;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
