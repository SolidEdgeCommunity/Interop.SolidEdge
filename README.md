Interop.SolidEdge
================
This repository contains community contributed libraries for the Solid Edge API.

* [Overview](https://github.com/SolidEdgeCommunity/CommunityFramework/wiki/Interop.SolidEdge#overview)
* [NuGet Package] (https://github.com/SolidEdgeCommunity/CommunityFramework/wiki/Interop.SolidEdge#nuget-package)
* [Installation](https://github.com/SolidEdgeCommunity/CommunityFramework/wiki/Interop.SolidEdge#installation)
* [Updates](https://github.com/SolidEdgeCommunity/CommunityFramework/wiki/Interop.SolidEdge#updates)
* [Versioning](https://github.com/SolidEdgeCommunity/CommunityFramework/wiki/Interop.SolidEdge#versioning)

# Overview
A single Interop Assembly containing all relevant Solid Edge API definitions. The compiled binaries are hosted at NuGet in package id [Interop.SolidEdge](https://www.nuget.org/packages/Interop.SolidEdge).

| Description | Type Library | Namespace |
| ------------- | ------------- | ------------- |
| Solid Edge Revision Manager Object Library | RevMgr.tlb | RevisionManager |
| Solid Edge Install Data Library | SEInstallData.dll | SEInstallDataLib |
| Solid Edge Assembly Type Library | assembly.tlb | SolidEdgeAssembly |
| Solid Edge Constants Type Library | constant.tlb | SolidEdgeConstants |
| Solid Edge Draft Type Library | draft.tlb | SolidEdgeDraft |
| Solid Edge File Properties Object Library | propauto.dll | SolidEdgeFileProperties |
| Solid Edge Framework Type Library | framewrk.tlb | SolidEdgeFramework |
| Solid Edge FrameworkSupport Type Library | fwksupp.tlb | SolidEdgeFrameworkSupport |
| Solid Edge Geometry Type Library | geometry.tlb | SolidEdgeGeometry |
| Solid Edge Part Type Library | Part.tlb | SolidEdgePart |
| Solid Edge Structure Editor Object Library | StructureEditor.tlb | StructureEditor |

# NuGet Package
The Interop.SolidEdge assembly is published as a [NuGet](https://www.nuget.org/) package. The package id is [Interop.SolidEdge](https://www.nuget.org/packages/Interop.SolidEdge). The package includes .NET 2.0 & 4.0 builds of the assembly. Depending on your project settings, NuGet will reference the appropriate assembly.

![](https://raw.githubusercontent.com/SolidEdgeCommunity/Interop.SolidEdge/master/media/NuGetPackageExplorer.png)

# Installation
The [Nuget Package Manager](http://docs.nuget.org/docs/start-here/managing-nuget-packages-using-the-dialog) provides a GUI interface for interacting with NuGet. Note that the steps will vary depending on your version of Visual Studio.

## Nuget Package Manager
![](https://raw.githubusercontent.com/SolidEdgeCommunity/Interop.SolidEdge/master/media/Install.png)

## Nuget Package Manager Console
The [Nuget Package Manager Console](http://docs.nuget.org/docs/start-here/using-the-package-manager-console) provides a command line style interface for interacting with NuGet. Note that the steps will vary depending on your version of Visual Studio.

![](https://raw.githubusercontent.com/SolidEdgeCommunity/Interop.SolidEdge/master/media/InstallCommandLine.png)

If you need a specific version of the package, you can use the following syntax.
![](https://raw.githubusercontent.com/SolidEdgeCommunity/Interop.SolidEdge/master/media/InstallVersionCommandLine.png)

# Updates
The Nuget Package Manager will inform you when updates to the package are available.

## Nuget Package Manager
![](https://raw.githubusercontent.com/SolidEdgeCommunity/Interop.SolidEdge/master/media/Update.png)

# Versioning
Starting with [Interop.SolidEdge 106.7.0](https://www.nuget.org/packages/Interop.SolidEdge/106.7.0), we will use the following scheme to version the assembly. As new versions of Solid Edge are released, a new build of Interop.SolidEdge will be published.

| Solid Edge | Solid Edge Version | Interop.SolidEdge Version |
| ------------- | ------------- | ------------- |
| Solid Edge ST6 MP7 | **106**.0.**7**.5 | [**106.7**.0](https://www.nuget.org/packages/Interop.SolidEdge/106.7.0) |
| Solid Edge ST6 MP8 | **106**.0.**8**.? | **106.8**.0 |
| Solid Edge ST7  | **107**.0.**0**.? | **107.0**.0 |
