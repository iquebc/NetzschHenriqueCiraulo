#########Netzsch##############

Hello everyone, i've builded an application with .net core 6.0 and React.
The project contains 4 projects
1 - .Net Web API with the .net core 6.0
2 - .Net classLib with the .net core 6.0
3 - .Net Windows Forms APP with the .net core 6.0
4 - NextJS Aplicattion for the web version

This project has two ways to input data and view the message.

1 - Windows APP
2 - NextJS APP

Both applications connect to the WEBAPI, which stores the information in memory and provides two methods for the applications: one for inserting messages and another for listing all received messages. In the future, it can be easily implemented with a database.

Unfortunately, I didn't have the opportunity to implement a real-time connection with WebSockets (SignalR) so that when a message is inserted in one of the applications, the view is automatically updated. Currently, it's necessary to click the "Refresh Message" button to view the sent message.

To run the project, you will need to have the .NET Core 6.0 SDK and NodeJS installed on your system. Below are the download links in case you don't have them:

#.NET 6.0 SDK: https://dotnet.microsoft.com/pt-br/download/dotnet/thank-you/sdk-6.0.414-windows-x64-installer

#NodeJS LTS Version: https://nodejs.org/en

there is three batch files that should be executed in order:

1 - RunWebAPI: This batch file is responsible for building and running the WEBAPI.

2 - RunWindowsAPP: This batch file is responsible for building and running the WindowsAPP.

3 - RunFrontEndAPP: This batch file is responsible for building and running the NextJS application. The Next application will run on port 3000 on localhost http://localhost:3000/ this need to be open in the browser

Make sure you have both the .NET SDK and NodeJS installed, and then execute these batch files in the specified order to run the project.
