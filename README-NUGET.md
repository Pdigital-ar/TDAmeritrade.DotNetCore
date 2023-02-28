Config NuGet Package
- In .csproj add:
<RepositoryUrl>https://github.com/Pdigital-ar/TDAmeritrade.DotNetCore</RepositoryUrl>
<GeneratePackageOnBuild>true</GeneratePackageOnBuild>
- In project root add Nuget.Config file:
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <clear/>
    <add key="github" value="https://nuget.pkg.github.com/Pdigital-ar/index.json"/>
  </packageSources>
  <packageSourceCredentials>
    <github>
      <add key="Username" value="JorgePinetta"/>
      <add key="ClearTextPassword" value="API-KEY"/>
    </github>
  </packageSourceCredentials>
</configuration>

Publish NuGet Package
> dotnet nuget push "bin/Release/TDAmeritrade.1.1.0.nupkg" --source "github"