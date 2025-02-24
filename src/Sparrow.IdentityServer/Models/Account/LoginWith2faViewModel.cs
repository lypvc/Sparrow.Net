﻿namespace Sparrow.IdentityServer.Models.Account
{
    public class LoginWith2faViewModel
    {
        public string TwoFactorCode { get; set; }
        public object ReturnUrl { get; internal set; }
        public bool RememberMe { get; internal set; }
        public bool RememberMachine { get; internal set; }
    }
}