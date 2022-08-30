using SalveTest.Service.Contracts;

namespace SalveTest.Service.Services
{
    public interface IClinicService
    {
        Task<IEnumerable<Clinic>> GetClinicsAsync();
    }
}
