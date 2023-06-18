using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gym_app_backend.Dtos
{
    public class UserSignUpDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool ReceiveDiscounts { get; set; }

    }
}