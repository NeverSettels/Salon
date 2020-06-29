# _Hair Salon!_

#### _June 29th 2020_

#### By _**Eric Settels**_

## Description

_This application will create a website where users can add stylists and then add clients to those specific stylists._

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:

- _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a
  .NET Core SDK from Microsoft Corp._
- _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings
  the installer suggests.)_

#### on Windows:

- _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download
  the 64-bit .NET Core SDK from Microsoft Corp._
- _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script

_Enter the command `dotnet tool install -g dotnet-script` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_

- `cd desktop`
- `git clone` followed by the URL to this repository
- `cd Salon.Solution`

_Confirm that you have navigated to the HairSalon directory (e.g., by entering the command_ `pwd` _in Terminal)._

_Build the database `eric_settels` using MySQL either manually, or through these MySQL commands in terminal/powershell:_

- _CREATE DATABASE eric_settels_;
- _Use eric_settels_;
- \_CREATE TABLE stylists (StylistId INT NOT NULL AUTO_INCREMENT, Name VARCHAR(255) NULL, PRIMARY KEY (StylistId));
- _CREATE TABLE clients (ClientId INT NOT NULL AUTO_INCREMENT, Name VARCHAR(255) NULL, StylistId INT NOT NULL,
  PreferredStylist VARCHAR(255) NULL, PRIMARY KEY (ClientId));_

_Run this application by entering the following command in Terminal (macOS) or PowerShell (Windows):_

- `cd HairSalon`
- `dotnet restore`
- `dotnet build`
- `dotnet run` or `dotnet watch run`

_To view/edit the source code of this application, open the contents of this directory in a text editor or IDE of your
choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ `code .` _in
Terminal)._

## Technologies Used

- _Git_
- _VSCode_
- _C#_
- _HTML_
- _Razor_
- _.NET Core 2.2_
- _ASP.NET Core MVC 2.2_
- _dotnet script_
- _MySQL_
- _MySQL Workbench_
- _Entity Framework Core 2.2_

### License

_This webpage is licensed under the MIT license._

Copyright (c) 2020 **_Eric SettelsC_**
