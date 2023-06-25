﻿using Skoruba.AuditLogging.Events;
using SiHuria.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Identity;

namespace SiHuria.IdentityServer4.Admin.BusinessLogic.Identity.Events.Identity
{
    public class ClaimUsersRequestedEvent<TUsersDto> : AuditEvent
    {
        public TUsersDto Users { get; set; }

        public ClaimUsersRequestedEvent(TUsersDto users)
        {
            Users = users;
        }
    }
}