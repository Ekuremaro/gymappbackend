using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gym_app_backend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = new byte[0];
        public byte[] PasswordSalt { get; set; } = new byte[0];
        public string Role { get; set; } = string.Empty;
        public bool ReceiveDiscounts { get; set; } = false;
        public bool RememberMe { get; set; } = false;
        public MembershipType membershipType { get; set; } = MembershipType.NoMembership;

    }
}