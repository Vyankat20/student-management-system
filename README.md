# Student Management System (ASP.NET Core)

## Features
- CRUD Operations (Student Management)
- JWT Authentication
- Layered Architecture (Controller → Service → Repository)
- Global Exception Handling
- Serilog Logging
- Swagger API Documentation
- SQL Server Integration

## Tech Stack
- ASP.NET Core Web API (.NET 8)
- Entity Framework Core
- SQL Server
- JWT Authentication

## How to Run

### 1. Update Connection String
Set SQL Server instance:
Server=.\\SQLEXPRESS

### 2. Run Migrations
dotnet ef database update

### 3. Run Application
dotnet run

### 4. API Testing
http://localhost:5000/swagger
Postman 

## Author
Vyankatesh Chopde

