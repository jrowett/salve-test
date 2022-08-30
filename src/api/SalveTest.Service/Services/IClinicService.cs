using SalveTest.Service.Contracts;

namespace SalveTest.Service.Services
{
    public interface IClinicService
    {
        IEnumerable<Clinic> GetClinics();
    }
}
