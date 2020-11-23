using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace URC_final.Models
{
    public class User
    {
        public IdentityUser identity { get; }
        public List<string> roles { get; }

        public User(IdentityUser identity, List<string> roles)
        {
            this.identity = identity;
            this.roles = roles;
        }


    }
}