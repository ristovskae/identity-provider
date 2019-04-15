﻿using IdentityServer4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdSrv.Quickstart.DTOs
{
    public class AADConfig
    {
        public string Authority { get; set; }
        public string ClientId { get; set; }
        public string DirectoryId { get; set; }
        public string SignOutScheme { get; set; } = IdentityServerConstants.SignoutScheme;
        public string SignInScheme { get; set; } = IdentityServerConstants.ExternalCookieAuthenticationScheme;
    }
}
