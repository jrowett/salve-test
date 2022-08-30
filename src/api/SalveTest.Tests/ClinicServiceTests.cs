using NUnit.Framework;
using SalveTest.Service.Services;
using System.Linq;
using System.Threading.Tasks;

namespace SalveTest.Tests
{
    public class ClinicServiceTests
    {
        [Test]
        public async Task ReturnsData()
        {
            var clinics = await new ClinicService().GetClinicsAsync();
            Assert.That(clinics.Count(), Is.EqualTo(2));
        }

        [Test]
        public async Task ContainsExpectedRecords()
        {
            var clinics = await new ClinicService().GetClinicsAsync();
            var record = clinics.FirstOrDefault(c => c.Name == "Salve Fertility");
            Assert.That(record, Is.Not.Null);
        }
    }


}