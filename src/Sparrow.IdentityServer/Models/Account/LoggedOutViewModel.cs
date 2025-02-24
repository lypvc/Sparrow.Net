﻿//using IdentityModel;
namespace Sparrow.IdentityServer.Models.Account
{
    public class LoggedOutViewModel
    {
        public object AutomaticRedirectAfterSignOut { get; internal set; }
        public string PostLogoutRedirectUri { get; internal set; }
        public string ClientName { get; internal set; }
        public string SignOutIFrameUrl { get; internal set; }
        public string LogoutId { get; internal set; }
        public string ExternalAuthenticationSchema { get; internal set; }
    }
}