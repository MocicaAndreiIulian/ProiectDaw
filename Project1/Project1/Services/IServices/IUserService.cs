using Project1.Auth;
using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Services.IServices
{
    public interface IUserService
    {
        User GetById(int id);
        List<User> GetAll();
        bool Register(RegisterRequest request);
        AuthResponse Login(AuthRequest request);
    }
}
