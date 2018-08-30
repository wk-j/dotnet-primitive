## .NET Primitive

Program

```
set packagePath /usr/local/share/dotnet/sdk/NuGetFallbackFolder
dotnet /usr/local/share/dotnet/sdk/2.1.4/Roslyn/bincore/csc.dll \
 -reference:$packagePath/microsoft.netcore.app/2.0.0/ref/netcoreapp2.0/System.Runtime.dll \
 -reference:$packagePath/microsoft.netcore.app/2.0.0/ref/netcoreapp2.0/System.Console.dll \
 -out:script/Program/P.dll \
      script/Program/P.cs

dotnet script/Program/P.dll
```

Download Newtonsoft.Json

```
mkdir -p packages/Newtonsoft.Json/10.0.3
curl -L https://www.nuget.org/api/v2/package/Newtonsoft.Json/10.0.3 | tar -xf - -C packages/Newtonsoft.Json/10.0.3/
```

```
set packagePath /usr/local/share/dotnet/sdk/NuGetFallbackFolder
dotnet /usr/local/share/dotnet/sdk/2.1.4/Roslyn/bincore/csc.dll \
    -reference:$packagePath/microsoft.netcore.app/2.0.0/ref/netcoreapp2.0/System.Runtime.dll \
    -reference:$packagePath/microsoft.netcore.app/2.0.0/ref/netcoreapp2.0/System.Console.dll \
    -reference:$packagePath/microsoft.netcore.app/2.0.0/ref/netcoreapp2.0/System.Collections.dll \
    -reference:packages/Newtonsoft.Json/10.0.3/lib/netstandard1.3/Newtonsoft.Json.dll \
    -out:script/Newton/N.dll \
    -nowarn:CS1701 \
    script/Newton/N.cs

cp ./packages/Newtonsoft.Json/10.0.3/lib/netstandard1.3/Newtonsoft.Json.dll script/Newton
dotnet script/Newton/N.dll
```