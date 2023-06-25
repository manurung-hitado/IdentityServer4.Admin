﻿using Skoruba.AuditLogging.Events;
namespace SiHuria.IdentityServer4.Admin.BusinessLogic.Identity.Events.Identity
{
    public class UserProviderRequestedEvent<TUserProviderDto> : AuditEvent
    {
        public TUserProviderDto Provider { get; set; }

        public UserProviderRequestedEvent(TUserProviderDto provider)
        {
            Provider = provider;
        }
    }
}