## .NET Primitive

```
set packagePath /usr/local/share/dotnet/sdk/NuGetFallbackFolder
dotnet /usr/local/share/dotnet/sdk/2.1.4/Roslyn/bincore/csc.dll \
 -reference:$packagePath/microsoft.netcore.app/2.0.0/ref/netcoreapp2.0/System.Runtime.dll \
 -reference:$packagePath/microsoft.netcore.app/2.0.0/ref/netcoreapp2.0/System.Console.dll \
 -out:script/Program.dll \
 script/Program.cs

dotnet script/Program.dll
```