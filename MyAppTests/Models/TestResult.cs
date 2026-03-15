using System;

namespace DiagnosticTestManagement.Models
{
    public class TestResult
    {
        public int ResultId { get; set; }
        public int PatientId { get; set; }
        public int TestId { get; set; }
        public string ResultValue { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
