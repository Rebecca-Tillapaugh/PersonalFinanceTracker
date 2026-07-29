# Personal Finance Tracker

## Overview
Personal Finance Tracker is a full-stack application for managing personal finances. The app is being built to help users organize transactions, categories, and budgets in one place.

## Current Status
The project has moved from initial planning into an implementation phase.

### What exists so far
- A backend ASP.NET Core Web API project
- Entity Framework Core models and persistence setup
- SQLite database support with Entity Framework Core migrations applied
- Development seed data configured for local development
- A frontend Angular application scaffolded under the frontend folder
- A basic health endpoint for backend verification

## Architecture
The solution currently follows a simple structure:

### Backend
- API entry point: backend/FinanceTracker.API/Program.cs
- Domain entities: backend/FinanceTracker.API/Domain/Entities
- DTOs and Application services: backend/FinanceTracker.API/Application
- Controllers: backend/FinanceTracker.API/Controllers
- Persistence and EF Core configuration: backend/FinanceTracker.API/Infrastructure/Persistence

### Frontend
- Angular app: frontend/finance-tracker-ui/finance-tracker-ui
- Main app shell: frontend/finance-tracker-ui/finance-tracker-ui/src/app

## Core Domain Concepts
The current domain model includes:
- Users
- Categories
- Transactions
- Budgets
- Budget categories

## Technology Stack
- C#
- ASP.NET Core Web API
- Entity Framework Core
- SQLite
- Angular
- TypeScript
- .NET 9

## Project Structure
- backend/FinanceTracker.API/ - ASP.NET Core API project
- backend/FinanceTracker.API/Domain/ - domain entities
- backend/FinanceTracker.API/Infrastructure/ - persistence and infrastructure code
- frontend/finance-tracker-ui/finance-tracker-ui/ - Angular frontend app

## How to Run the Project

### 1. Start the backend
From the project root, run:
```powershell
cd backend/FinanceTracker.API
dotnet run
```

The API will start locally and expose a health endpoint at:
- http://localhost:5083/health

### 2. Start the frontend
In a second terminal, run:
```powershell
cd frontend/finance-tracker-ui/finance-tracker-ui
npm start
```

Angular will start the local development server, usually at:
- http://localhost:4200/

If port 4200 is already in use, Angular may choose another port. Use the URL shown in the terminal.

### 3. Verify the app
- Open the frontend URL in your browser
- Optionally verify the backend health endpoint directly

## Database
The app uses SQLite for local development. The database file is stored at backend/FinanceTracker.API/finance-tracker.db
Database schema changes are managed through Entity Framework Core migrations.

## Planned Next Steps
- Implement CRUD APIs for categories, transactions, and budgets
- Connect the Angular UI to the backend
- Build a dashboard and finance management screens
- Add validation, styling, and improved UX

## Roadmap

### Backend
- [x] Project setup
- [x] ASP.NET Core Web API configuration
- [x] Entity Framework Core setup
- [x] Database models and relationships
- [x] Initial database migration
- [x] SQLite database integration
- [x] Health check endpoint
- [ ] Category CRUD API
- [ ] Transaction CRUD API
- [ ] Budget CRUD API
- [ ] User management
- [ ] Authentication and authorization
- [ ] API validation and error handling
- [ ] Unit tests
- [ ] Integration tests

### Frontend
- [x] Angular project setup
- [x] Application routing
- [ ] User authentication screens
- [ ] Dashboard layout
- [ ] Transaction management page
- [ ] Category management page
- [ ] Budget management page
- [ ] Data visualization and charts
- [ ] Connect frontend to backend API
- [ ] Responsive design and UI improvements

### Additional Features
- [ ] Transaction search and filtering
- [ ] Monthly spending summaries
- [ ] Budget progress tracking
- [ ] Budget alerts
- [ ] Import/export transactions

### Deployment & DevOps
- [ ] Docker containerization
- [ ] CI/CD pipeline
- [ ] Cloud deployment
- [ ] Production database configuration