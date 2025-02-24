﻿//using IdentityModel;
namespace Sparrow.IdentityServer.Models.Account
{
    public class LoginViewModel
    {
        public bool RememberMe { get; internal set; }
        public string UserName { get; internal set; }
        public object AllowRememberLogin { get; internal set; }
        public bool EnableLocalLogin { get; internal set; }
        public string ReturnUrl { get; internal set; }
        public object ExternalProviders { get; internal set; }
        public bool IsExternalLoginOnly { get; internal set; }
        public object ExternalLoginScheme { get; internal set; }
    }
}