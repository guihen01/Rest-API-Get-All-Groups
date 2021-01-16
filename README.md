# Tools :

coded in C#

Development platform : Visual studio 2019

use Microsoft Net.Core

use Json package (newtonsoft.Json v12.0.3)

# How to use :
allow to make a rest api request to jira server it is based on rest api library of Atlassian ref : https://docs.atlassian.com/software/jira/docs/api/REST/8.13.2/ the excutable code when lounched ask some questions for starting the corresponding rest API

# Parameters

URL of the jira server whith the port number :
( ie : exemple : http://localhost:8080 )

The program then make a concatenation with /rest/api/2/groups/picker  
The result is the end point on which to send the REst API httprequest :: http://localhost:8080/rest/api/2/groups/picker

auth : username and password of a granted account to jira server

# Distribution

it is distributed as nuget package

reference to download the package is : https://www.nuget.org/packages/Get-All-Jira-Groups/

# Sample :
Sample
See sample in  .........................


