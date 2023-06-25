﻿using SiHuria.IdentityServer4.Admin.Api.ExceptionHandling;

namespace SiHuria.IdentityServer4.Admin.Api.Resources
{
    public class ApiErrorResources : IApiErrorResources
    {
        public virtual ApiError CannotSetId()
        {
            return new ApiError
            {
                Code = nameof(CannotSetId),
                Description = ApiErrorResource.CannotSetId
            };
        }
    }
}