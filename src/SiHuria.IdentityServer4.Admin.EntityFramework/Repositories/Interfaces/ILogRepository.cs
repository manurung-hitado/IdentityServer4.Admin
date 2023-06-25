using System;
using System.Threading.Tasks;
using SiHuria.IdentityServer4.Admin.EntityFramework.Entities;
using SiHuria.IdentityServer4.Admin.EntityFramework.Extensions.Common;

namespace SiHuria.IdentityServer4.Admin.EntityFramework.Repositories.Interfaces
{
    public interface ILogRepository
    {
        Task<PagedList<Log>> GetLogsAsync(string search, int page = 1, int pageSize = 10);

        Task DeleteLogsOlderThanAsync(DateTime deleteOlderThan);

        bool AutoSaveChanges { get; set; }
    }
}