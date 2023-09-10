# ASP.NET Application with Razor Pages, Entity Framework Core, and Northwind Database

## Overview
This application is built using ASP.NET Core and includes Razor Pages, Entity Framework Core, and uses the Northwind Database. It also includes class libraries for unit testing.

## Getting Started

### Prerequisites
- .NET Core SDK
- Visual Studio or any preferred code editor
- SQL Server (for the Northwind database)

### Installation
1. Clone the repository.
2. Open the solution in Visual Studio.
3. Update the connection string in `appsettings.json` to point to your SQL Server instance.
4. Run the command `Update-Database` in the Package Manager Console. This will create the Northwind database in your SQL Server instance.

## Usage
Run the application from Visual Studio or use `dotnet run` command from the terminal.

## Project Structure
- **Razor Pages**: The application uses Razor syntax to create dynamic web content.
- **Entity Framework Core**: Used for data access, it allows performing CRUD operations without writing SQL queries.
- **Northwind Database**: A sample database provided by Microsoft, used for demonstrating concepts of database design and manipulation.
- **Unit Testing**: The application includes class libraries for unit testing to ensure code quality and correctness.

## Running Tests
Tests can be run directly from Visual Studio or by using the `dotnet test` command from the terminal.

## Contributing
Please read `CONTRIBUTING.md` for details on our code of conduct, and the process for submitting pull requests.

## License
This project is licensed under the MIT License - see the `LICENSE.md` file for details.
