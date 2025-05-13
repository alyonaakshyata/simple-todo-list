# To-Do List App (C# + SQL)

A simple C# console application that allows users to add and view to-do tasks, with SQL integration to store tasks in a database.

## Features

- Add new tasks
- View all tasks
- Simple menu-driven interface
- Store tasks in an SQL database (SQL Server)
- Clean and modular C# code

## Prerequisites

Before running the app, ensure you have the following:

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) installed (version 6.0+ recommended)
- SQL Server installed (or an available SQL database)
- SQL Server Management Studio (SSMS) (optional, for managing the database)
- A terminal or command prompt
- (Optional) Visual Studio or VS Code for editing

## Getting Started

### 1. Set up SQL Server

Create the database and table using the following SQL commands in your SQL Server Management Studio or your preferred SQL interface.

```sql
CREATE DATABASE TodoAppDB;

USE TodoAppDB;

CREATE TABLE Tasks (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Description NVARCHAR(255) NOT NULL,
    IsCompleted BIT NOT NULL DEFAULT 0
);

### 2. Install .NET Packages

Install the required SQL client package to interact with the SQL Server:

```bash
dotnet add package System.Data.SqlClient

### 3. Clone the Repository

Clone or download the project repository to your local machine.

```bash
git clone https://github.com/yourusername/todoapp.git
cd todoapp


### 4. Modify the Connection String

In the `Program.cs` file, update the connection string to point to your SQL Server instance. The default connection string is as follows:

```csharp
static string connectionString = "Server=localhost;Database=TodoAppDB;Trusted_Connection=True;";


### 5. Run the Application

Once the database is set up and the connection string is updated, run the application:

```bash
dotnet run

