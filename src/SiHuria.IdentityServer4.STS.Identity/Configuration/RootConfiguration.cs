using SiHuria.IdentityServer4.Shared.Configuration.Configuration.Identity;
using SiHuria.IdentityServer4.STS.Identity.Configuration.Interfaces;

namespace SiHuria.IdentityServer4.STS.Identity.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {      
        public AdminConfiguration AdminConfiguration { get; } = new AdminConfiguration();
        public RegisterConfiguration RegisterConfiguration { get; } = new RegisterConfiguration();
    }
}