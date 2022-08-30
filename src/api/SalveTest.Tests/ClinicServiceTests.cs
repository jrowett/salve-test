using NUnit.Framework;
using SalveTest.Service.Services;
using System.Linq;

namespace SalveTest.Tests
{
    public class ClinicServiceTests
    {
        [Test]
        public void ReturnsData()
        {
            var clinics = new ClinicService().GetClinics();
            Assert.That(clinics.Count(), Is.GreaterThan(0));
        }
    }


}