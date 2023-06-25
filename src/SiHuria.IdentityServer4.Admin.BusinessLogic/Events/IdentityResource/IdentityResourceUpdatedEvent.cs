using Skoruba.AuditLogging.Events;
using SiHuria.IdentityServer4.Admin.BusinessLogic.Dtos.Configuration;

namespace SiHuria.IdentityServer4.Admin.BusinessLogic.Events.IdentityResource
{
    public class IdentityResourceUpdatedEvent : AuditEvent
    {
        public IdentityResourceDto OriginalIdentityResource { get; set; }
        public IdentityResourceDto IdentityResource { get; set; }

        public IdentityResourceUpdatedEvent(IdentityResourceDto originalIdentityResource, IdentityResourceDto identityResource)
        {
            OriginalIdentityResource = originalIdentityResource;
            IdentityResource = identityResource;
        }
    }
}