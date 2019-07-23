﻿using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace Sparrow.Security.Models
{
    public class UserClaim : IdentityUserClaim<string>
    {
        public virtual User User { get; set; }

        public UserClaim()
        {
             
        }

        public UserClaim(string userId, string type, string value)
        {
            base.UserId = userId;
            base.InitializeFromClaim(new Claim(type, value));
        }
    }
}
