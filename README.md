# Content
This project contains set of interfaces for [AutoUpdateApplication](https://github.com/csharp-today/AutoUpdateApplication) - the projct that makes creating auto-updating applications easy.

# NuGet
The latest stable version is available as NuGet package - [AutoUpdate.Common](https://www.nuget.org/packages/AutoUpdate.Common/).

# Interfaces

## IAutoUpdateApplication
This interface has to be implemented if one want to create auto-updating application - [details](https://github.com/csharp-today/AutoUpdate.Common/blob/master/AutoUpdate.Common/AutoUpdate.Common/IAutoUpdateApplication.cs).

## IAutoUpdateService
This inerface is meant for auto-updating applications that need to run as Windows Service - [details](https://github.com/csharp-today/AutoUpdate.Common/blob/master/AutoUpdate.Common/AutoUpdate.Common/IAutoUpdateService.cs).

## IAutoUpdateMetadata
Object implementing this interface is passed to auto-updating application. It contains metadata information useful for diagnosing application stub - [details](https://github.com/csharp-today/AutoUpdate.Common/blob/master/AutoUpdate.Common/AutoUpdate.Common/IAutoUpdateMetadata.cs).
