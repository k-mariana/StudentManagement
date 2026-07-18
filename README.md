# Student Management System

## Overview

Student Management System is a three-tier application developed with **C#**, **ASP.NET Core Web API**, **Windows Forms**, **Entity Framework Core**, and **Microsoft SQL Server**.

The application demonstrates a clean separation of responsibilities between the database, business logic, and presentation layers while following **REST principles**, **Repository Pattern**, and **DTO Pattern**.

The project provides **JWT authentication** and a desktop client for managing students through a secure Web API.

---

## Architecture

The solution consists of three layers:

### 1. Database Layer

- Microsoft SQL Server
- Entity Framework Core (Code First)
- Database Migrations
- Seed data for User and Students

### 2. Web API Layer

- ASP.NET Core Web API
- RESTful API
- JWT Authentication
- Repository Pattern
- DTO Pattern
- Entity Framework Core
- Swagger (OpenAPI)

### 3. Presentation Layer

- Windows Forms (.NET)
- JWT Authentication
- Student CRUD operations
- Communication with Web API using HttpClient

---

## Technologies

- C#
- .NET 9
- ASP.NET Core Web API
- Windows Forms
- Entity Framework Core
- Microsoft SQL Server
- JWT Authentication
- Swagger (OpenAPI)
- Repository Pattern
- DTO Pattern
- REST API

---

## Features

### Authentication

- User login
- JWT token generation
- Protected API endpoints
- Password hashing using ASP.NET Core Identity PasswordHasher

### Student Management

- View students
- Add new students
- Update students
- Delete students
- Server-side pagination
- Search by ID, First Name, and Last Name
- Server-side sorting

### User Interface

- Login form
- Password masking with show/hide option
- Student management form
- DataGridView with:
  - Custom column headers
  - Responsive column sizing
  - Pagination
  - Search
  - Sorting
- Success and validation notifications

---

## Getting Started

### Clone the repository

```bash
git clone https://github.com/k-mariana/StudentManagement
```

### Create the database

Run Entity Framework migrations:

```powershell
Update-Database
```

### Run the Web API

Start the **StudentManagement.Api** project.

### Run the Windows Forms application

Start the **StudentManagement.WinForms** project.

### Login

Use the seeded administrator account:

```text
Login:    admin
Password: admin123
```
