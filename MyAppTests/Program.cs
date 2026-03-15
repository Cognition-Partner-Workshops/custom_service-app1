using System;
using MyAppTests.Tests;
using LibraryApp.Tests;
using OrderManagement.Tests;

namespace MyAppTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Login Tests...");
            new LoginTests().Run();

            Console.WriteLine("\nRunning User Creation Tests...");
            new UserCreationTests().Run(); 

            Console.WriteLine("\nAll tests completed.");
            
            Console.WriteLine("\n=== Running LibraryApp Tests ===");
            new LibraryTests().Run();

            Console.WriteLine("\nAll tests completed.");
            Console.WriteLine("Running Order Management Tests...");
            new OrderTests().Run();
            Console.WriteLine("All tests completed.");
        }
    }
}
