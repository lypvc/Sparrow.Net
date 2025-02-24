﻿using System;

namespace Sparrow.IdentityServer.Models.Account
{
    public class AccountOptions
    {
        public static string InvalidCredentialsErrorMessage { get; set; }
        public static bool ShowLogoutPrompt { get; internal set; }
        public static bool AllowLocalLogin { get; internal set; }
        public static string AllowRememberLogin { get; internal set; }
        public static string AutomaticRedirectAfterSignOut { get; internal set; }
        public static string WindowsAuthenticationSchemeName { get; internal set; }
    }
}