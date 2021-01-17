# Tools :

coded in C#

Development platform : Visual studio 2019

use Microsoft Net.Core

use Json package (newtonsoft.Json v12.0.3)

# How to use :
allow to make a rest api request to jira server it is based on rest api library of Atlassian ref : https://docs.atlassian.com/software/jira/docs/api/REST/8.13.2/ the excutable code when lounched ask some questions for starting the corresponding rest API

1) download the nuget package Get-All-Jira-Groups at  https://www.nuget.org/packages/Get-All-Jira-Groups/ and insert the package in your project
2) OR copy and paste from this github repository the Program.cs code in your C# project , compile (build and execute)  

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

Is is also distributed as a published application (git .zip file in : .........) 
the zip file is a compressed folder that include the published application 

publishiong profile :  ................... 

configuration : Release / any CPU
T
arget framework : netcoreapp3.1

Deployment mode : Framework dependent

Target Runtime : Portable




