using NUnit.Framework;
using SalveTest.Service.Services;
using System.Linq;
using System.Threading.Tasks;

namespace SalveTest.Tests
{
    public class PatientServiceTests
    {
        [TestCase(1)]
        [TestCase(2)]
        public async Task ReturnsData(int clinicId)
        {
            var patients = await new PatientService().GetPatientsForClinicAsync(clinicId);
            Assert.That(patients.Count(), Is.GreaterThan(0));
        }

        [Test]
        public void DoesNotThrowWhenInvalidClinicId()
        {
            Assert.DoesNotThrowAsync(async () => await new PatientService().GetPatientsForClinicAsync(0));
        }
    }


}