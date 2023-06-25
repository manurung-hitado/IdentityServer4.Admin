using System.ComponentModel.DataAnnotations;
using SiHuria.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Identity.Base;
using SiHuria.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Identity.Interfaces;

namespace SiHuria.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Identity
{
    public class RoleDto<TKey> : BaseRoleDto<TKey>, IRoleDto
    {      
        [Required]
        public string Name { get; set; }
    }
}