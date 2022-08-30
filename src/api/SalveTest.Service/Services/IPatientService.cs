using SalveTest.Service.Contracts;

namespace SalveTest.Service.Services
{
    public interface IPatientService
    {
        Task<IEnumerable<Patient>> GetPatientsForClinicAsync(int clinicId);
    }
}
