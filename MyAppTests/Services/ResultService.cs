using System.Collections.Generic;
using DiagnosticTestManagement.Models;

namespace DiagnosticTestManagement.Services
{
    public class ResultService
    {
        private readonly List<TestResult> _results = new List<TestResult>();

        public void AddResult(TestResult result) => _results.Add(result);

        public List<TestResult> GetResultsByPatient(int patientId) =>
            _results.FindAll(r => r.PatientId == patientId);
    }
}
