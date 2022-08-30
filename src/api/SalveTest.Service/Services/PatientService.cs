using SalveTest.Service.Contracts;

namespace SalveTest.Service.Services
{
    public class PatientService : IPatientService
    {
        public IEnumerable<Patient> GetPatientsForClinic(int clinicId)
        {
            return new[]
            {
                new Patient {Id = 1, FirstName = "Joe", LastName = "Bloggs", DateOfBirth = DateTime.Now.AddYears(-40).Date},
                new Patient {Id = 2, FirstName = "Jane", LastName = "Bloggs", DateOfBirth = DateTime.Now.AddYears(-40).Date}
            };
        }
    }
}
