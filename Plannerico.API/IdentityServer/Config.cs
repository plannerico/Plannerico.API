// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId()
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {   new ApiScope("plannerico.api", "Plannerico API") };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                     ClientId = "plannerico.client",
                     ClientSecrets = { new Secret("secret".Sha256()) },

                     AllowedGrantTypes = GrantTypes.Code,

                     // where to redirect to after login
                     RedirectUris = { "https://localhost:5002/signin-oidc" },

                     // where to redirect to after logout
                     PostLogoutRedirectUris = { "https://localhost:5002/signout-callback-oidc" },

                     AllowOfflineAccess = true,

                     AllowedScopes = new List<string>
                     {
                         IdentityServerConstants.StandardScopes.OpenId,
                         IdentityServerConstants.StandardScopes.Profile,
                         "plannerico.api"
                     }
                }
            };
    }
}