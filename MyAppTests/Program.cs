using System;
using MyAppTests.Tests;
using LibraryApp.Tests;

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
        }
    }
}
