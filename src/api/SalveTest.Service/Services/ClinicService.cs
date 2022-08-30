using SalveTest.Service.Contracts;

namespace SalveTest.Service.Services
{

    public class ClinicService : IClinicService
    {
        public IEnumerable<Clinic> GetClinics()
        {
            return new[]
            {
                new Clinic {Id = 1, Name = "Test Clinic 1"},
                new Clinic {Id = 2, Name = "Test Clinic 2"}
            };
        }
    }
}
