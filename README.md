# 🎓 Student Management System (ASP.NET Core)

## 📌 Overview
This project is a RESTful Web API built using ASP.NET Core that allows managing student records. It supports secure operations using JWT authentication and follows a clean layered architecture.

---

## 🚀 Features
- ✅ CRUD Operations (Create, Read, Update, Delete)
- 🔐 JWT Authentication & Authorization
- 🏗 Layered Architecture (Controller → Service → Repository)
- ⚠ Global Exception Handling Middleware
- 📄 Swagger API Documentation
- 🗄 SQL Server Integration
- 📊 Logging using Serilog

---

## 🛠 Tech Stack
- ASP.NET Core Web API (.NET 8)
- Entity Framework Core
- SQL Server (SQLEXPRESS)
- JWT Authentication
- Swagger (Swashbuckle)
- Serilog Logging

---

## 📂 Project Structure
Controllers/ → API endpoints
Services/ → Business logic
Repositories/ → Data access layer
Models/ → Entity models
Data/ → DbContext
Middleware/ → Exception handling


---

## 🔐 Authentication Flow
1. Call `/api/Auth/login`
2. Copy the generated JWT token
3. Use token in request header:
Authorization: Bearer <your_token>
for simplicity use Postman only use <token>

**Run Migration**
dotnet ef database update


4.** Run Application**
dotnet run
5. Access Swagger
http://localhost:5000/swagger
🧪 API Testing
Use Swagger UI or Postman
Authenticate using JWT token
Test endpoints like:
GET /api/Student
POST /api/Student
PUT /api/Student/{id}
DELETE /api/Student/{id}

Sample Example
{
  "id": 1,
  "name": "virat",
  "email": "virat@example.com",
  "age": 22,
  "course": "IT"
}
🌟 Future Improvements
Role-based authorization (Admin/User)
Pagination & filtering
Frontend integration (React/Angular)
