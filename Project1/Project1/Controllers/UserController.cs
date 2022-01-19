﻿using Microsoft.AspNetCore.Mvc;
using Project1.Auth;
using Project1.Models;
using Project1.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpPost("register")]
        public IActionResult Register([FromForm] RegisterRequest request)
        {
            var Result = _userService.Register(request);
            if (Result)
            {
                return Ok();
            }
            else
            {
                return Conflict();
            }
        }

        [HttpPost("login")]
        public IActionResult Login([FromForm] AuthRequest request)
        {
            return Ok(_userService.Login(request));
        }


        [HttpGet("all")]
        [Authorize]
        public IActionResult GetAll()
        {
            var user = (User)HttpContext.Items["User"];
            return Ok(_userService.GetAll().ToList());
        }
    }
}
