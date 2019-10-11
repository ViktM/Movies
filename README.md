# Movies`

For this webapp you need to spin up a Microsoft Sql Server in docker
Follow these steps:

1. Set up docker and login in your command line

2.	sudo docker pull microsoft/mssql-server-linux:2017-latest

3.	Create new container by using the below script. Make sure you use a strong enough password otherwise you will not be able to run it

sudo docker run -e 'ACCEPT_EULA=Y' \
-e 'SA_PASSWORD=P@ssw0rd!' \
-p 1433:1433 \
--name sql1 \
-d microsoft/mssql-server-linux:2017-latest

4. With the following you can check your containers and their status
docker ps -a

5. Check logs with:
docker logs {container_name}

6. Start up server
docker start {container_name}

7. Once the database server is up and running, open Azure and connect to it by filling in the required information. 
Add localhost as host. “sa” (system admin) as username and the password from the script

8. I used dotnet sdk 3.0.0 - do double check what you have because if you have an older version a few libraires might not work

9. In case you chose webappMVC and the comiler complaines a lot about libraries and you can include them it might be 
because the EntityFrameworkCore SQL server is not included in general try:
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 3.0.0


# References

How to spin up a MS sql server through docker and hook it up to a .net backend
https://codeburst.io/how-to-set-up-a-modern-full-stack-net-web-development-environment-on-mac-os-542dcd43a564

Download and install Azure Data Studio
https://docs.microsoft.com/en-us/sql/azure-data-studio/download?view=sql-server-2017

Quickstart: Run SQL Server container images with Docker
https://docs.microsoft.com/en-us/sql/linux/quickstart-install-connect-docker?view=sql-server-2017&pivots=cs1-bash

Troubleshooting - Configure SQL Server container images on Docker
https://docs.microsoft.com/en-us/sql/linux/sql-server-linux-configure-docker?view=sql-server-2017#troubleshooting

Create a web app with ASP.NET Core MVC
https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/?view=aspnetcore-3.0