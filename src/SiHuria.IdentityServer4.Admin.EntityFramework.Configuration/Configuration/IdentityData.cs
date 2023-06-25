﻿using System.Collections.Generic;
using SiHuria.IdentityServer4.Admin.EntityFramework.Configuration.Configuration.Identity;

namespace SiHuria.IdentityServer4.Admin.EntityFramework.Configuration.Configuration
{
	public class IdentityData
    {
       public List<Role> Roles { get; set; }
       public List<User> Users { get; set; }
    }
}
