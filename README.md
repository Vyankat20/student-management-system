# Student__Management__System (ASP.NET Core) Using Rest Api

## 📌 Overview
This is a RESTful Web API built using ASP.NET Core that allows management of student data with secure JWT-based authentication.

## 🚀 Features
- CRUD Operations (Create, Read, Update, Delete)
- JWT Authentication & Authorization
- Layered Architecture (Controller → Service → Repository)
- Global Exception Handling Middleware
- Serilog Logging
- Swagger API Documentation
- SQL Server Integration

## 🛠 Tech Stack
- ASP.NET Core (.NET 8)
- Entity Framework Core
- SQL Server
- JWT Authentication
- Swagger
- Docker (optional)

## 🔐 Authentication
1. Call `/api/Auth/login`
2. Copy JWT token
3. Use in Authorization header:
   Bearer <token>

## ⚙️ Setup Instructions

### 1. Update Connection String