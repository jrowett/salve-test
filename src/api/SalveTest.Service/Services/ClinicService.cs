using CsvHelper;
using SalveTest.Service.Contracts;
using System.Globalization;

namespace SalveTest.Service.Services
{

    public class ClinicService : IClinicService
    {
        public async Task<IEnumerable<Clinic>> GetClinicsAsync()
        {
            const string csv = "SampleData\\clinics.csv";

            if (!File.Exists(csv))
            {
                throw new FileNotFoundException("Clinics data is missing. Please ensure the CSV file is present in the deployment directory");
            }

            using (var textReader = new StreamReader(csv))
            using(var csvReader = new CsvReader(textReader, CultureInfo.InvariantCulture))
            {
                csvReader.Context.RegisterClassMap<ClinicMap>();
                return await csvReader.GetRecordsAsync<Clinic>().ToListAsync();
            }
        }
    }
}
