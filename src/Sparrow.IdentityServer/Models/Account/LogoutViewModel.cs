﻿//using IdentityModel;
namespace Sparrow.IdentityServer.Models.Account
{
    public class LogoutViewModel
    {
        public string LogoutId { get; internal set; }
        public bool ShowLogoutPrompt { get; internal set; }
    }
}