# ASP.NET Core & EntityFramework Core

## Introduction
CRUD-music is a simple crud music api, built with asp.net core & entity framework core and integrate with database Microsoft SQL Server.

## Prerequirements

* Visual Studio 2019
* .NET Core SDK
* SQL Server

## How To Run

* Open solution in Visual Studio 2019.
* Open appsetting.json and in ConnectionStrings change the database connection as your own database connection.
* Open Microsofot SQL Server and Restore backup database that include in this repository (dbmusic.bak).
* Run the application.

## End Point

**1. GET**
* `/artist/` (get all list artist/music)
* `/artist/:id/` (get detail artist/music by id)

**2. POST**
* `/artist/addartist` (add new artist/music)

**3. PUT**
* `/artist/:id` (update artist/music by id)

**4. DELETE**
* `/artist/:id` (delete artist/music by id)


