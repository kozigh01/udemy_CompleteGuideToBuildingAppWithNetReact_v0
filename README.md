# Complete guide to building an app with .Net Core and React
course: [udemy](https://www.udemy.com/course/complete-guide-to-building-an-app-with-net-core-and-react/) | [github](https://github.com/TryCatchLearn/Reactivities30)

## Resources
* dot net: [main](https://dotnet.microsoft.com/) | [docker](https://hub.docker.com/_/microsoft-dotnet) | [docker .net sdk 5](https://hub.docker.com/_/microsoft-dotnet-sdk/)
* entity framework:
  * intall:
    ```bash
    $ dotnet tool install --global dotnet-ef
    $ export PATH="$PATH:$HOME/.dotnet/tools/
    ```
  * Make sure to install 'Microsoft.EntityFrameworkCore.Design' in /API project and run migrations from there.
  * Sqlite3:  to get vs code extension to work, install sqlite3:
    ```bash
    $ sudo apt-get update
    $ sudo apt-get install sqlite3
    ```
    then set the vs code settings for sqlite->sqlite command or binaries path to "/usr/bin/sqlite3"  
  *
