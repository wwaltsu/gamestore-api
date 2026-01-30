# 🎮 GameStore API

This API allows clients to manage a collection of video games and their genres through a RESTful interface.

A modern **ASP.NET Core Web API** for managing video games and genres, built with **.NET 10**, **Entity Framework Core**, and **SQLite**.

This project focuses on learning clean API structure, database integration, and modern backend best practices.

---

## 📚 Project Background

This project was built as a learning exercise following along with the excellent tutorial:

**“ASP.NET Core Full Course For Beginners (.NET 10)” by Julio Casal**

The course was used as a foundation to understand:

- ASP.NET Core Web API architecture  
- Entity Framework Core  
- Database migrations & seeding  
- DTOs and validation  
- Dependency Injection  

---

## 🚀 API Endpoints

### 🎯 Games API

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/games` | List all games |
| GET | `/games/{id}` | Get game details |
| POST | `/games` | Create a new game |
| PUT | `/games/{id}` | Update a game |
| DELETE | `/games/{id}` | Delete a game |

### 🗂 Genres API

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/genres` | List all available genres |

---

## 🧠 Concepts Practiced

- Minimal APIs in ASP.NET Core  
- Dependency Injection (DI)  
- Entity Framework Core with SQLite  
- Async database operations  
- DTO mapping and validation  
- Database migrations  
- Database seeding  
- RESTful API design  
- Git history hygiene (clean commits & refactoring)

---

## 🛠 Tech Stack

- .NET 10  
- ASP.NET Core  
- Entity Framework Core  
- SQLite  
- C#  

---

## 🗄 Database

The project uses **SQLite** for simplicity.

- Automatic database migrations on startup  
- The database is pre-populated with default game genres (seeding)  
- `Game` ↔ `Genre` relationship  

---

## ▶️ Running the Project

### 1️⃣ Clone the repository

```bash
git clone https://github.com/wwaltsu/GameStore.git
cd GameStore/GameStore.Api
dotnet run
