$templateRoot = "template-publish/content"
$templateSrc = "template-publish/content/src"
$temporaryProjectFolder = "SiHuriaIdentityServer4Admin"
$templateDockerFolder = "template-docker"

# Remove original src folder for publish folder
if ((Test-Path -Path $templateSrc)) { Remove-Item ./$templateSrc -recurse -force }

# Copy new src folder
Copy-Item ./$temporaryProjectFolder/src ./$templateSrc -recurse -force
Copy-Item ./$temporaryProjectFolder/shared ./$templateRoot  -recurse -force
Copy-Item ./$temporaryProjectFolder/package ./$templateRoot  -recurse -force
Copy-Item ./$temporaryProjectFolder/.dockerignore ./$templateRoot  -recurse -force
Copy-Item ./$temporaryProjectFolder/docker-compose.dcproj ./$templateRoot  -recurse -force
Copy-Item ./$temporaryProjectFolder/docker-compose.override.yml ./$templateRoot  -recurse -force
Copy-Item ./$temporaryProjectFolder/docker-compose.vs.debug.yml ./$templateRoot  -recurse -force
Copy-Item ./$temporaryProjectFolder/docker-compose.vs.release.yml ./$templateRoot  -recurse -force
Copy-Item ./$temporaryProjectFolder/docker-compose.yml ./$templateRoot  -recurse -force
Copy-Item ./$temporaryProjectFolder/Directory.Build.props $templateRoot -recurse -force
Copy-Item ./$temporaryProjectFolder/LICENSE.md $templateRoot -recurse -force

# Copy docker files for Admin, Api and STS
Copy-Item ./$templateDockerFolder/SiHuriaIdentityServer4Admin.Admin/* $templateSrc/SiHuriaIdentityServer4Admin.Admin -recurse -force
Copy-Item ./$templateDockerFolder/SiHuriaIdentityServer4Admin.Admin.Api/* $templateSrc/SiHuriaIdentityServer4Admin.Admin.Api -recurse -force
Copy-Item ./$templateDockerFolder/SiHuriaIdentityServer4Admin.STS.Identity/* $templateSrc/SiHuriaIdentityServer4Admin.STS.Identity -recurse -force