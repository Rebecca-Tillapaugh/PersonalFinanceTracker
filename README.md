# Personal Finance Tracker

## Overview
The Personal Finance Tracker is a full-stack application for managing personal finances. The goal is to help users track income, expenses, categories, and budgets in a simple and organized way.

## Current Backend Direction
The backend is being built as an ASP.NET Core Web API with a clean architecture approach:
- Domain entities live under the backend domain layer
- Entity Framework Core is used for persistence
- The application is structured to support future services, DTOs, and controllers

## Core Domain Concepts
The current model focuses on four main business areas:
- Users
- Transactions
- Categories
- Budgets

## Backend Structure
- Domain entities: backend/FinanceTracker.API/Domain/Entities
- Persistence and EF Core setup: backend/FinanceTracker.API/Infrastructure/Persistence
- API entry point: backend/FinanceTracker.API/Program.cs

## Technology Stack
- C#
- ASP.NET Core Web API
- Entity Framework Core
- .NET 9

## Planned Features
- User registration and account management
- Transaction creation and tracking
- Category-based organization
- Budget creation and spending limits
- Financial reporting and summaries

## Project Status
The project is in the early architecture and modeling stage, with the domain model and persistence layer being established first.