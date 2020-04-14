using LaserCutting.Models;
using System;

namespace LaserCutting.Application
{
    public interface ITokenRepository
    {
        User Authenticate(string username, string password);
    }
}
