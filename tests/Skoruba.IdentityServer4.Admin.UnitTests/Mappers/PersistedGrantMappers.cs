﻿using System;
using FluentAssertions;
using SiHuria.IdentityServer4.Admin.BusinessLogic.Mappers;
using SiHuria.IdentityServer4.Admin.UnitTests.Mocks;
using Xunit;

namespace SiHuria.IdentityServer4.Admin.UnitTests.Mappers
{
    public class PersistedGrantMappers
    {
        [Fact]
        public void CanMapPersistedGrantToModel()
        {
            var persistedGrantKey = Guid.NewGuid().ToString();

            //Generate entity
            var persistedGrant = PersistedGrantMock.GenerateRandomPersistedGrant(persistedGrantKey);

            //Try map to DTO
            var persistedGrantDto = persistedGrant.ToModel();

            //Asert
            persistedGrantDto.Should().NotBeNull();

            persistedGrant.Should().BeEquivalentTo(persistedGrantDto, options => options.Excluding(x => x.SubjectName));
        }
    }
}