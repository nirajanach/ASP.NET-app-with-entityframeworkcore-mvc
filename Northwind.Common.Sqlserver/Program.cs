using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Packt.Shared;
using static System.Runtime.InteropServices.JavaScript.JSType;


public class Program
{
    static void Main(string[] args)
    {
        Northwinds db = new();

        Console.WriteLine($"Provider: {db.Database.ProviderName}");
    }
}



