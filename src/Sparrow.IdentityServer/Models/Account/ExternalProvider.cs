﻿//using IdentityModel;
namespace Sparrow.IdentityServer.Models.Account
{
    public class ExternalProvider
    {
        public string AuthenticationScheme { get; set; }
        public object DisplayName { get; internal set; }
    }
}