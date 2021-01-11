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
 * Docker
    * node:15:

      ```bash
      $ docker run -it node:15

      $ docker run -it -d --name mynode node:15
      $ docker exec -it mynode ls

      $ docker run -it node:15 npm ls
      ```

    * util:

      * npm

        ```bash
        $ docker build -t node-npm -f Dockerfile.npm .

        $ docker run -it -v $(pwd):/app node-npm init -y
        ```

      * npx

        ```bash
        $ docker build -t node-npx -f Dockerfile.npx .

        $ docker run -it -v $(pwd):/app node-npx create-react-app app --template typescript
        ```
        