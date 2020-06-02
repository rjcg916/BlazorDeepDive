# Get started

In this section, we'll setup a machine for Blazor development and build our first Blazor app.

## Setup

To get started with Blazor, follow the instructions on https://aka.ms/blazor-getting-started.

## Building starter apps

Blazor has two major hosting models.  
- Webassembly - application runs as a Client-side SPA
- Server - application runs as a .NET Core application with incremental, client-side rendering

In order to compare and contrast these models, we will use Visual Studio 2019 to create three solutions from Blazor Template projects as follows:
- Webassembly  - create a Blazor App and choose the Webassembly Template. 
- Server - create a Blazor App and choose the Server Template
- Hosted Deployment - Create a Blazor App, choose the Webassembly Template AND select the .net core hosting option.  This solution will contain three projects - client, server, and shared


In the next section, we will examine the details of these solutions.

Next up - [Hosting and Deployment](01-hosting-and-deployment.md)