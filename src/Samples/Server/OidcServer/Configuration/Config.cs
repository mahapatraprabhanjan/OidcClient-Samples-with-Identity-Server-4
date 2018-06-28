using System.Collections.Generic;
using IdentityServer4.Models;

namespace OidcServer.Configuration
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("api1","My API")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId="Xamarin",
                    ClientName="Xamarin Test Client",
                    AllowedGrantTypes = GrantTypes.Hybrid,
                    AllowOfflineAccess = true,
                    AllowedScopes = {"api1"},
                    RequirePkce = true,
                    RequireClientSecret = false,
                    AllowAccessTokensViaBrowser = true,
                    RedirectUris = {"xamarinclient://identitycallback"},
                    PostLogoutRedirectUris = {"xamarinclient://logut"}
                }
            };
        }
    }
}
