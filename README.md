# Tools :

coded in C#

Development platform : Visual studio 2019

use Microsoft Net.Core

use Json package (newtonsoft.Json v12.0.3)

# How to use :
allow to make a rest api request to jira server it is based on rest api library of Atlassian ref : https://docs.atlassian.com/software/jira/docs/api/REST/8.13.2/ the excutable code when lounched ask some questions for starting the corresponding rest API

# Parameters

1) URL of the jira server whith the port number :
( ie : exemple : http://localhost:8080 )

The program then make a concatenation with /rest/api/2/groups/picker  
The result is the end point on which to send the REst API httprequest :: http://localhost:8080/rest/api/2/groups/picker

2) auth : username and password of a granted account to jira server

# Outputs

1) The program create a json formated file , it includes all the Jira groups 
name of the file created : List-groups.json
exemple (text formated sample) : at : https://github.com/guihen01/Rest-API-Get-All-Groups/blob/main/Screenshots/List-groups.txt

2) The program create a text formated file , (json to string) it includes all the Jira groups 
name of the file created : List-groups.txt
exemple (json formated) : at https://github.com/guihen01/Rest-API-Get-All-Groups/blob/main/Screenshots/List-groups.json

# Distribution

it is distributed as nuget package

reference to download the package is : https://www.nuget.org/packages/Get-All-Jira-Groups/

# Sample :
Sample
See sample in  https://github.com/guihen01/Rest-API-Get-All-Groups/blob/main/Screenshots/List-groups.txt


