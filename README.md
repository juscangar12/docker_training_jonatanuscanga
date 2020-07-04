# docker_training_jonatanuscanga
COMMANDS

[Creating the Image]
Command:docker build -f "E:\Develop\AT\dockertraining_jonatan_uscanga\Dockerfile" --force-rm -t mywebappdocker

[List Images]
Command:docker images
----------------------------------------------------------------------------------------------------------
REPOSITORY                             TAG                   IMAGE ID            CREATED             SIZE
myappwebdockertraining                 latest                684b4aa11409        4 hours ago         375MB 
-----------------------------------------------------------------------------------------------------------

[Creating and running container from Image configuring port 8085]
Command:docker run --name Site1 -p 8085:80 684b4aa11409
---------------------------------------------------------------------------------------
warn: Microsoft.AspNetCore.DataProtection.Repositories.FileSystemXmlRepository[60]
      Storing keys in a directory 'C:\Users\ContainerUser\AppData\Local\ASP.NET\DataProtection-Keys' that may not be persisted outside of the container. Protected data will be unavailable when container is destroyed.
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: http://[::]:80
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Production
info: Microsoft.Hosting.Lifetime[0]
      Content root path: C:\app
---------------------------------------------------------------------------------------


[Creating and running container from Image configuring port 8086, configuring two variables]
Command:docker run --name Site2 -p 8086:80 684b4aa11409 -e "AppSettings:SubTitle"="Finally I had time ... from Docker" "AppSettings:StoreName"="Plano"
-----------------------------------------------------------------------------------------------------------------------------------------------
warn: Microsoft.AspNetCore.DataProtection.Repositories.FileSystemXmlRepository[60]
      Storing keys in a directory 'C:\Users\ContainerUser\AppData\Local\ASP.NET\DataProtection-Keys' that may not be persisted outside of the container. Protected data will be unavailable when container is destroyed.
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: http://[::]:80
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Production
info: Microsoft.Hosting.Lifetime[0]
      Content root path: C:\app
-----------------------------------------------------------------------------------------------------------------------------------------------

docker tag a083f8d2f768 dockertraining2020/compose_jonatanuscanga:tagname

docker push dockertraining2020/compose_jonatanuscanga:tagname
