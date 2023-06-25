using Microsoft.EntityFrameworkCore;
using SiHuria.IdentityServer4.Admin.EntityFramework.Entities;

namespace SiHuria.IdentityServer4.Admin.EntityFramework.Interfaces
{
    public interface IAdminLogDbContext
    {
        DbSet<Log> Logs { get; set; }
    }
}
