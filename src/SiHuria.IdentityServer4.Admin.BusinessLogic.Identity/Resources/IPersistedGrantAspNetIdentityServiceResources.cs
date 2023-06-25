using SiHuria.IdentityServer4.Admin.BusinessLogic.Identity.Helpers;

namespace SiHuria.IdentityServer4.Admin.BusinessLogic.Identity.Resources
{
    public interface IPersistedGrantAspNetIdentityServiceResources
    {
        ResourceMessage PersistedGrantDoesNotExist();

        ResourceMessage PersistedGrantWithSubjectIdDoesNotExist();
    }
}
