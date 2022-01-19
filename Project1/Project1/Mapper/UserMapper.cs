using Project1.Auth;
using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Mapper
{
    public static class UserMapper
    {
        public static User ToUserExtension(this RegisterRequest request)
        {
            return new User
            {
                Email = request.Mail,
                Password = request.Password,
                CasaId = request.CasaId

            };
        }
    }
}
