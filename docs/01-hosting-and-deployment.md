# Overview


Assemblies/Framework
    Client - wasm compatible .net assemblies, _Imports.Razor
    Server - .net core , asp.net core with blazor
    Hosted - WebAssembly.Server - responsible for delivery of client app

Application / Layout
    Client - App.razor - routing on browser  index.html + MainLayout.razor
    Server - App.razor - routing on server  
                        _Host.cshtml + MainLayout.razor + Index.Razor

                        _Host.cshtml - a razor page, target of all requests
                        RenderComponent - point to Server Side App
                        blazor.server.js - client/server comm

    Hosted - _Layout (server) Razor
             + Client

Settings
    Client - launchsettings.json  + Wasm profile ???
    https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/blazor/webassembly?view=aspnetcore-3.1#host-configuration-values 
    https://www.reddit.com/r/Blazor/comments/erc5jl/how_can_i_load_appsettings_into_blazor_client_side/ 
    Server - launchsetting.json + BlazorServer profile, appsettings.json

Services/Pipeline
    Client - webassembly host builder + http client - program.cs
https://www.reddit.com/r/Blazor/comments/erc5jl/how_can_i_load_appsettings_into_blazor_client_side/

    Server - .net core + SignalR - program.cs + startup.cs - 
                AddServerSideBlazor
    
                MapBlazorHub
                MapFallBackToPage("/_Host")

    Hosted - .net core delivers client wasm

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

conceptual
https://docs.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-3.1#blazor-webassembly 



## Server Side / .NET Core
conceptual

https://docs.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-3.1#blazor-server 



## Server Hosting of Client
conceptual

https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/blazor/webassembly?view=aspnetcore-3.1#hosted-deployment-with-aspnet-core 



# Deployment

## Client Side / Wasm

Static Hosting in Azure

publish, copy files
next step, pipeline

https://docs.microsoft.com/en-us/azure/storage/blobs/storage-blob-static-website

https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/blazor/webassembly?view=aspnetcore-3.1#azure-storage 
https://docs.microsoft.com/en-us/azure/storage/blobs/storage-blob-static-website-how-to?tabs=azure-portal

https://microsoft.github.io/AzureTipsAndTricks/blog/tip221.html 

https://timheuer.com/blog/deploy-blazor-app-to-azure-using-github-actions

## Server Side 

.Net Core/Razor Web App in Azure

https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/blazor/server?view=aspnetcore-3.1

https://docs.microsoft.com/en-us/azure/azure-signalr/ 

## Server Hosting

.net Core/ Client Web App in Azure
https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/blazor/webassembly?view=aspnetcore-3.1#hosted-deployment-with-aspnet-core

https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/?view=aspnetcore-3.1
https://docs.microsoft.com/en-us/aspnet/core/tutorials/publish-to-azure-webapp-using-vs?view=aspnetcore-3.1