using Skoruba.AuditLogging.Events;
using SiHuria.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Grant;

namespace SiHuria.IdentityServer4.Admin.BusinessLogic.Identity.Events.PersistedGrant
{
    public class PersistedGrantsIdentityByUsersRequestedEvent : AuditEvent
    {
        public PersistedGrantsDto PersistedGrants { get; set; }

        public PersistedGrantsIdentityByUsersRequestedEvent(PersistedGrantsDto persistedGrants)
        {
            PersistedGrants = persistedGrants;
        }
    }
}