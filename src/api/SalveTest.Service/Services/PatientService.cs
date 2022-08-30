using CsvHelper;
using SalveTest.Service.Contracts;
using System.Globalization;

namespace SalveTest.Service.Services
{
    public class PatientService : IPatientService
    {
        public async Task<IEnumerable<Patient>> GetPatientsForClinicAsync(int clinicId)
        {
            var csv = $"SampleData\\patients-{clinicId}.csv";

            if (!File.Exists(csv))
            {
                return null;
            }

            using (var textReader = new StreamReader(csv))
            using (var csvReader = new CsvReader(textReader, CultureInfo.InvariantCulture))
            {
                csvReader.Context.RegisterClassMap<PatientMap>();
                return await csvReader.GetRecordsAsync<Patient>().ToListAsync();
            }
        }
    }
}
