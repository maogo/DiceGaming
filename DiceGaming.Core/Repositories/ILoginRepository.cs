﻿using DiceGaming.Core.Models;
using System.Collections.Generic;

namespace DiceGaming.Core.Repositories
{
    public interface ILoginRepository
    {
        LoginDto Get(int id);
        IEnumerable<LoginDto> GetUserLogins(int userId);
        LoginDto LoginUser(LoginDto login);
        void Delete(int id);
        bool HasLoginAndToken(int loginId, string token);
        bool HasUserAndToken(int userId, string token);
    }
}
