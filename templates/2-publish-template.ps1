param([string] $packagesVersions)

$templateNuspecPath = "template-publish/SiHuria.IdentityServer4.Admin.Templates.nuspec"
nuget pack $templateNuspecPath -NoDefaultExcludes

dotnet.exe new --uninstall SiHuria.IdentityServer4.Admin.Templates

$templateLocalName = "SiHuria.IdentityServer4.Admin.Templates.$packagesVersions.nupkg"
dotnet.exe new -i $templateLocalName

dotnet.exe new sihuria.is4admin --name MyProject --title MyProject --adminemail 'admin@SiHuria.com' --adminpassword 'Pa$$word123' --adminrole MyRole --adminclientid MyClientId --adminclientsecret MyClientSecret --dockersupport true