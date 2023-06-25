﻿using System.ComponentModel.DataAnnotations;
using SiHuria.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Identity.Base;
using SiHuria.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Identity.Interfaces;

namespace SiHuria.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Identity
{
    public class RoleClaimDto<TKey> : BaseRoleClaimDto<TKey>, IRoleClaimDto
    {
        [Required]
        public string ClaimType { get; set; }


        [Required]
        public string ClaimValue { get; set; }
    }
}
