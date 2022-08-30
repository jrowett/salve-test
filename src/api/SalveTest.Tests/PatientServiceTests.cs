using NUnit.Framework;
using SalveTest.Service.Services;
using System.Linq;

namespace SalveTest.Tests
{
    public class PatientServiceTests
    {
        [Test]
        public void ReturnsData()
        {
            var patients = new PatientService().GetPatientsForClinic(1);
            Assert.That(patients.Count(), Is.GreaterThan(0));
        }
    }


}