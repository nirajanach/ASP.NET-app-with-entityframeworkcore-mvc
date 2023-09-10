using Microsoft.Data.SqlClient; //To use SqlConnectionStringBuilder.
using Microsoft.EntityFrameworkCore; //To use DbContext, DbContextOptionsBuilder.
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;

namespace Packt.Shared;

// This manages the connection to the database
public class Northwinds  : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        SqlConnectionStringBuilder builder = new();

        builder.DataSource = @"JARVIS\SQLEXPRESS";

        builder.InitialCatalog = "Northwind";
        builder.IntegratedSecurity = true;
        builder.TrustServerCertificate = true;
        builder.MultipleActiveResultSets = true;
        builder.ConnectTimeout = 3;

        string connection = builder.ConnectionString;

        ConsoleColor previousColor = Console.ForegroundColor;
        Console.WriteLine($"Connection : {connection}");
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.ForegroundColor = previousColor;

        optionsBuilder.UseSqlServer(connection);

    }
}