﻿namespace Sparrow.IdentityServer.Models.Account
{
    public class LoginFormModel
    {
        public string ReturnUrl { get; set; }
        public string UserName { get;  set; }
        public string Password { get;  set; }
        public bool RememberMe { get;  set; }
    }
}