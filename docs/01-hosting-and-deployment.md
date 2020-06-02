# Overview

Dependencies
    Client - wasm compatible .net assemblies, _Imports.Razor
    Server - .net core , asp.net core with blazor
    Hosted - WebAssembly.Server - responsible for delivery of client app

Application / Layout
    Client - App.razor - routing on browser  index.html + MainLayout.razor
    Server - App.razor - routing on server (ultimately to client) 
                        _Host.cshtml + MainLayout.razor + Index.Razor
    Hosted - _Layout (server)
             + Client

Settings
    Client - launchsettings.json  + Wasm profile ???
    Server - launchsetting.json + BlazorServer profile, appsettings.json

Startup
    Client - program.cs - webassembly host builder + http client

    Server - program.cs + startup.cs - 
                AddServerSideBlazor
    
                MapBlazorHub
                MapFallBackToPage("/_Host")

    Hosted -

            UseWebAssemblyDebugging
			UseBlazorFrameworkFiles

            MapRazorPages
			MapControllers
			MapFallbackToFile("index.html")


|               | Client                | Server            | Hosted                        |
|----           | -----                 | ----              | ----                          |
| Dependencies  | WebAssembly           | AspNetCore.App    | WebAssembly.Server            |
|               | System.Net.Http.Json  | NETCore.App       |                               |
|               | NETStandardLibrary    |                   |                               |
|               |                       |                   |                               |
| App           | App.razor             | App.Razor         | App.Razor (client and server)
|               | _Imports.Razor          _Imports.Razor
|               |
| Layout        |  MainLayout.razor     | MainLayout.razor  | MainLayout (client)           |
                                          _Host.cshtml      |   _Layout.cshtml (server)     |
|   
| Settings      | www/appsetting        | appsettings.*.json | appsettings.*.json (serve and client) |


| Startup       |                       |                   
                                          startup


	

				        		                                startup (server)
								                                UseWebAssemblyDebugging
								                                UseBlazorFrameworkFiles
					
					                    MapBlazorHub		
					                    MapFallbackToPage	
								                                MapRazorPages
								                                MapControllers
								                                MapFallbackToFile

## Client Side / Wasm

https://docs.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-3.1#blazor-webassembly 



## Server Side / .NET Core

https://docs.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-3.1#blazor-server 



## Server Hosting of Client

https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/blazor/webassembly?view=aspnetcore-3.1#hosted-deployment-with-aspnet-core 



# Deployment

## Client Side / Wasm
https://docs.microsoft.com/en-us/azure/storage/blobs/storage-blob-static-website

https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/blazor/webassembly?view=aspnetcore-3.1#azure-storage 
https://docs.microsoft.com/en-us/azure/storage/blobs/storage-blob-static-website-how-to?tabs=azure-portal

## Server Side 
https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/blazor/server?view=aspnetcore-3.1

## Server Hosting
https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/blazor/webassembly?view=aspnetcore-3.1#hosted-deployment-with-aspnet-core

https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/?view=aspnetcore-3.1
https://docs.microsoft.com/en-us/aspnet/core/tutorials/publish-to-azure-webapp-using-vs?view=aspnetcore-3.1