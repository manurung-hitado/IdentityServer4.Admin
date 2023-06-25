using System;
using System.Threading.Tasks;
using SiHuria.IdentityServer4.Admin.BusinessLogic.Dtos.Log;

namespace SiHuria.IdentityServer4.Admin.BusinessLogic.Services.Interfaces
{
    public interface ILogService
    {
        Task<LogsDto> GetLogsAsync(string search, int page = 1, int pageSize = 10);

        Task DeleteLogsOlderThanAsync(DateTime deleteOlderThan);
    }
}