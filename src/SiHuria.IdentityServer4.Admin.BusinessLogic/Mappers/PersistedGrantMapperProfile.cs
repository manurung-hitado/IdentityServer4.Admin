﻿using AutoMapper;
using IdentityServer4.EntityFramework.Entities;
using SiHuria.IdentityServer4.Admin.BusinessLogic.Dtos.Grant;
using SiHuria.IdentityServer4.Admin.EntityFramework.Entities;
using SiHuria.IdentityServer4.Admin.EntityFramework.Extensions.Common;

namespace SiHuria.IdentityServer4.Admin.BusinessLogic.Mappers
{
    public class PersistedGrantMapperProfile : Profile
    {
        public PersistedGrantMapperProfile()
        {
            // entity to model
            CreateMap<PersistedGrant, PersistedGrantDto>(MemberList.Destination)
                .ReverseMap();

            CreateMap<PersistedGrantDataView, PersistedGrantDto>(MemberList.Destination);

            CreateMap<PagedList<PersistedGrantDataView>, PersistedGrantsDto>(MemberList.Destination)
                .ForMember(x => x.PersistedGrants,
                    opt => opt.MapFrom(src => src.Data));

            CreateMap<PagedList<PersistedGrant>, PersistedGrantsDto>(MemberList.Destination)
                .ForMember(x => x.PersistedGrants,
                    opt => opt.MapFrom(src => src.Data));            
        }
    }
}
