using System.Collections.Generic;
using DiagnosticTestManagement.Models;

namespace DiagnosticTestManagement.Services
{
    public class PatientService
    {
        private readonly List<Patient> _patients = new List<Patient>();

        public void RegisterPatient(Patient patient) => _patients.Add(patient);

        public Patient GetPatientById(int id) => _patients.Find(p => p.PatientId == id);

        public List<Patient> GetAllPatients() => _patients;
    }
}
