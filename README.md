# Tools :
[![Get-All-Jira-Groups on fuget.org](https://www.fuget.org/packages/Get-All-Jira-Groups/badge.svg)](https://www.fuget.org/packages/Get-All-Jira-Groups)
[![Build status](https://ci.appveyor.com/api/projects/status/owefd7trpnhho5hc?svg=true)](https://ci.appveyor.com/project/guihen01/rest-api-get-all-groups)
[![NuGet](https://img.shields.io/nuget/v/Get-All-Jira-Groupsj.svg)](https://www.nuget.org/packages/Get-All-Jira-Groupsj/)

Get all JIRA groups and store them in 2 files

coded in C#

Development platform : Visual studio 2019

use Microsoft Net.Core

use Json package (newtonsoft.Json v12.0.3)

# How to get :
allow to make a rest api request to jira server it is based on rest api library of Atlassian ref : https://docs.atlassian.com/software/jira/docs/api/REST/8.13.2/ the excutable code when lounched ask some questions for starting the corresponding rest API

1) Download the nuget package Get-All-Jira-Groups at  https://www.nuget.org/packages/Get-All-Jira-Groups/ and insert the package in your project or download the nuget package at : https://github.com/guihen01/Rest-API-Get-All-Groups/packages/611796

OR

2) Copy and paste from this github repository the Program.cs code in your C# project , compile (build and execute) 

OR

3) Download the published application on this site :https://github.com/guihen01/Rest-API-Get-All-Groups/releases/tag/new

# How to use

https://github.com/guihen01/Rest-API-Get-All-Groups/blob/main/Screenshots/Capture2.PNG
![alt text](https://github.com/guihen01/Rest-API-Get-All-Groups/blob/main/Screenshots/Capture2.PNG  "Logo Title Text 1")

include the reference : using System.Threading.Tasks; & using GetGroups;

in your code : use : await Pg.GetAllGroups();   (GetAllGroups() method is packed and assembled in the dll :  and included in the Pg class

https://github.com/guihen01/Rest-API-Get-All-Groups/blob/main/Screenshots/Capture5.PNG
![alt text]( https://github.com/guihen01/Rest-API-Get-All-Groups/blob/main/Screenshots/Capture5.PNG "Logo Title Text 1")

 
# Parameters

1) URL of the jira server whith the port number :
( ie : exemple : http://localhost:8080 )

The program then make a concatenation with /rest/api/2/groups/picker 
The result is the end point on which to send the REst API httprequest :: http://localhost:8080/rest/api/2/groups/picker

2) auth : username and password of a granted account to jira server

# Outputs

1) The program create a json formated file , it includes all the Jira groups	

name of the file created : List-groups.json

exemple (json formated sample) : at : https://github.com/guihen01/Rest-API-Get-All-Groups/blob/main/Screenshots/List-groups.json


2) The program create a text formated file , (json to string) it includes all the Jira groups
.  
name of the file created : List-groups.txt

exemple (text formated) : at https://github.com/guihen01/Rest-API-Get-All-Groups/blob/main/Screenshots/List-groups.txt

# Distribution 1 

it is distributed as nuget package

reference to download the package is : https://www.nuget.org/packages/Get-All-Jira-Groups/

# Distribution 2

Is is also distributed as a published application (git .zip file) 

Get-All-Jira-Groups.zip

The zip file is a compressed folder that include the published application 

publishing profile :  https://github.com/guihen01/Rest-API-Get-All-Groups/blob/main/Publishing%20Profile.PNG

configuration : Release / any CPU

Target framework : netcoreapp3.1

Deployment mode : Framework dependent

Target Runtime : Portable




