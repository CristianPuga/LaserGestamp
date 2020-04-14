using LaserCutting.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaserCutting.Application
{
    public class TokenService : ITokenService
    {
        private readonly ITokenRepository _tokenRepository;

        public TokenService(ITokenRepository tokenRepository) 
        {
            _tokenRepository = tokenRepository;
        }

        public User Authenticate(string username, string password)
        {
            return _tokenRepository.Authenticate(username, password);
        }
    }
}
