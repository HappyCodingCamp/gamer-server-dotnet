# Gamer AI Server

Provides REST API for Gamer AI client

Built with .NET Core

## Prerequisites: 

- Install .NET Core
- Install local PostgreSQL server (use [official docs](https://www.postgresql.org/) for your system)
- Manage project secrets and DB connection string ([read here](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-2.1&tabs=linux))

## ENV config

The project run config depends on the following environment variables 

ASPNETCORE_ENVIRONMENT=Development

ASPNETCORE_URLS=https://localhost:5001;http://localhost:5000

## Running for the first time

- Create initial database by running `dotnet ef database update`
- if app fails to run because of the missing SSL certificate, generate self-signed SSL certificate by following the 
instructions in the CLI

## Accessing swagger

Swagger UI should be accessible from 

http://localhost:5000/swagger

https://localhost:5001/swagger

There is a problem at the moment with Swagger UI. If app runs both on HTTP and HTTPS ports, Swagger UI "try it out" 
functionality will work only in the UI loaded from HTTPS port.