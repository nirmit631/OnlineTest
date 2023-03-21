﻿using OnlineTest.Model;
using OnlineTest.Model.Interfaces;
using OnlineTest.Services.Interface;

namespace OnlineTest.Services.Services
{
    public class RTokenService : IRTokenService
    {
        private readonly IRTokenRepository _rTokenRepository;
        public RTokenService(IRTokenRepository rTokenRepository)
        {

            _rTokenRepository = rTokenRepository;
        }

        public bool AddToken(RToken token)
        {
            return _rTokenRepository.Add(token);
        }

        public bool ExpireToken(RToken token)
        {
            return _rTokenRepository.Expire(token);
        }

        public RToken GetToken(string refreshToken)
        {
            return _rTokenRepository.Get(refreshToken);
        }
    }
}
