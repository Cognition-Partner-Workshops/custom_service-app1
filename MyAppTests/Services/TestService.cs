using System.Collections.Generic;
using DiagnosticTestManagement.Models;

namespace DiagnosticTestManagement.Services
{
    public class TestService
    {
        private readonly List<DiagnosticTest> _tests = new List<DiagnosticTest>();

        public void AddTest(DiagnosticTest test) => _tests.Add(test);

        public DiagnosticTest GetTestById(int id) => _tests.Find(t => t.TestId == id);

        public List<DiagnosticTest> GetAllTests() => _tests;
    }
}
