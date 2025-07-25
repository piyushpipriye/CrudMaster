# CrudMaster 🛠️

**CrudMaster** is a simple ASP.NET Core Web API project that demonstrates CRUD operations using Entity Framework Core and SQL Server.

## 🌐 Technologies Used

- ASP.NET Core 8.0 / 9.0
- Entity Framework Core
- SQL Server / LocalDB
- Swagger / Swashbuckle for API documentation
- Visual Studio / VS Code
- Git + GitHub for version control

## 📦 Features

- ✅ Create, Read, Update, and Delete (CRUD) APIs
- 🔄 Database-First or Code-First Entity Framework Integration
- 🧪 Built-in Swagger UI for testing endpoints
- 🔐 Clean architecture ready for extension

## 🚀 Getting Started

### Clone the repository

```bash
git clone git@github-piyush:piyushpipriye/CrudMaster.git
cd CrudMaster

Run with .NET CLI
bash
Copy
Edit
dotnet restore
dotnet build
dotnet run
Swagger UI will be available at:
http://localhost:<port>/swagger

Make sure to set up your connection string in appsettings.json.


🧱 Project Structure
bash
Copy
Edit
CrudMaster/
├── Controllers/         # API Controllers
├── Data/                # EF Core DbContext
├── Models/              # Entity Models
├── Program.cs           # Main entry point
├── appsettings.json     # Configuration file
└── launchSettings.json  # 
