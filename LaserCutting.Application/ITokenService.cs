using LaserCutting.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaserCutting.Application
{
    public interface ITokenService
    {
        User Authenticate(string username, string password);
    }
}
