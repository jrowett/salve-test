using SalveTest.Service.Contracts;

namespace SalveTest.Service.Services
{
    public interface IPatientService
    {
        IEnumerable<Patient> GetPatientsForClinic(int clinicId);
    }
}
