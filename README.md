# 🛍️ MVC E-Commerce Application

A robust and scalable E-Commerce platform built with **ASP.NET Core 3.1 MVC**, featuring secure JWT authentication, efficient data management with Entity Framework Core, and a clean separation of concerns.

## 🚀 Features

-   **User Authentication**: Secure login and registration system using **JWT (JSON Web Tokens)**.
-   **Product Management**: CRUD operations for managing products effectively.
-   **Order Processing**: Streamlined order placement and tracking.
-   **Transaction Handling**: Secure transaction services integrated.
-   **API First Approach**: Dedicated API controllers for external integrations (`/api/`).
-   **MVC Architecture**: Clean Model-View-Controller pattern for maintainable code.
-   **AutoMapper**: Simplified object-to-object mapping.
-   **SQL Server Support**: built on top of Entity Framework Core for SQL Server.

## 🛠️ Tech Stack

-   **Framework**: .NET Core 3.1
-   **Architecture**: MVC (Model-View-Controller)
-   **Database**: SQL Server (Entity Framework Core)
-   **Authentication**: JWT Bearer
-   **Tools**: AutoMapper, Dependency Injection

## 📂 Project Structure

-   `Controllers/`: Handles incoming HTTP requests for both Views and APIs.
-   `Services/`: Business logic layer (Users, Products, Orders, Transactions).
-   `Models/`: Database entities and domain models.
-   `Dtos/`: Data Transfer Objects for API communication.
-   `Views/`: Razor views for the frontend interface.

## 🔧 Getting Started

### Prerequisites

-   [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet/3.1)
-   SQL Server

### Installation

1.  **Clone the repository**
    ```bash
    git clone https://github.com/saicharanrajoju/MVC.git
    cd MVC
    ```

2.  **Configure Database**
    Update your connection string in `appsettings.json` to point to your local SQL Server instance.

3.  **Run Migrations** (Optional, if using Code First)
    ```bash
    dotnet ef database update
    ```

4.  **Build and Run**
    ```bash
    dotnet run
    ```

## 🔐 Configuration

The application uses `appsettings.json` for configuration. API keys and secrets (like `JwtConfig:SecretKey`) should be managed securely (e.g., using User Secrets in development).


