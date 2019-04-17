﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System;

namespace IdentityServer4.Quickstart.UI
{
    public class AccountOptions
    {
        public static bool AllowLocalLogin = true;
        public static bool AllowRememberLogin = true;
        public static TimeSpan RememberMeLoginDuration = TimeSpan.FromDays(30);

        public static bool ShowLogoutPrompt = false;
        public static bool AutomaticRedirectAfterSignOut = true;//ako e true posle Logout i brishenje na cookies-ta redirektira na Home url-to 

        // to enable windows authentication, the host (IIS or IIS Express) also must have 
        // windows auth enabled.
        public static bool WindowsAuthenticationEnabled = false;
        public static bool IncludeWindowsGroups = false;
        // specify the Windows authentication scheme and display name
        public static readonly string WindowsAuthenticationSchemeName = "Windows";

        public static string InvalidCredentialsErrorMessage = "Invalid username or password";
    }
}
