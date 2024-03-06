using System;
using System.Collections.Generic;
using System.Text;
using AuthServer.Core.Configuration;
using AuthServer.Core.DTOs;
using AuthServer.Core.Models;

namespace AuthServer.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(UserApp userApp);

        ClientTokenDto CreateTokenByClient(Client client);
    }
}