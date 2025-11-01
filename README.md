# TaskManagementApp

## Overview

TaskManagementApp is a streamlined and user-friendly task management system built with Blazor and .NET 8. Designed for simplicity and efficiency, it allows users to manage daily tasks without navigating between pages. Whether you're organizing a personal to-do list or handling multiple priorities, this app makes task tracking intuitive and seamless.

## Features

- **Single Page Application**: Enjoy a smooth, uninterrupted workflow with a fully interactive single-page interface.
- **Inline Editing**: Edit tasks directly within the task view—no pop-ups or page reloads required.
- **Task Filtering**: Quickly sort and view tasks by due date, priority, or completion status.
- **Clean and Intuitive UI**: A modern and accessible design that works well across devices and screen sizes.

## Technologies Used

- **Blazor**: Interactive web UI built with C#
- **.NET 8**: Backend powered by the latest .NET framework
- **SQL Server**: Relational database for persistent task storage
- **Entity Framework Core**: ORM with LINQ for data access and manipulation

## Getting Started

### Prerequisites

To run this project, you'll need:

- **.NET 8 SDK**: Download and install the latest version of the .NET 8 SDK from the [official website](https://dotnet.microsoft.com/download/dotnet/8.0).
- **Visual Studio 2022** (recommended) or any other C# IDE.

### Create Database Model

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/zafry26/TaskManagementApp.git
   ```
2. \*\*Navigate to the Project Directory:
   ```bash
   cd ClassLibraryDal
   ```
3. \*\*Create Migration & Update Database:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```
4. \*\*Run the Application:
   ```bash
   dotnet run
   ```

### Running the Application

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/zafry26/TaskManagementApp.git
   ```
2. \*\*Navigate to the Project Directory:
   ```bash
    cd TaskManagementApp
   ```
3. \*\*Build the Project:
   ```bash
   dotnet build
   ```
4. \*\*Run the Application:
   ```bash
   dotnet run
   ```

### Completed Task

![alt text](<Screenshot 2025-11-02 at 1.39.20 AM.png>)

### Pending Task

![alt text](<Screenshot 2025-11-02 at 1.39.02 AM.png>)

### Create Task

![alt text](<Screenshot 2025-11-02 at 1.39.59 AM.png>)

### Delete Task

![alt text](<Screenshot 2025-11-02 at 1.42.30 AM.png>)

## Special Thanks

This project is a clone of HadiaFaisal19/TaskManagementApp. Special thanks to the original author for the inspiration and foundation.
