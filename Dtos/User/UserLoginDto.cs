using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gym_app_backend.Dtos.User
{
    public class UserLoginDto
    {
        public string EmailAddress { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool RememberMe { get; set; } = false;
    }
}