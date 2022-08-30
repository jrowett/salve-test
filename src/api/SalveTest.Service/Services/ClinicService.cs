using CsvHelper;
using SalveTest.Service.Contracts;
using System.Globalization;

namespace SalveTest.Service.Services
{

    public class ClinicService : IClinicService
    {
        public async Task<IEnumerable<Clinic>> GetClinics()
        {
            using (var textReader = new StreamReader("SampleData\\clinics.csv"))
            using(var csvReader = new CsvReader(textReader, CultureInfo.InvariantCulture))
            {
                csvReader.Context.RegisterClassMap<ClinicMap>();
                return await csvReader.GetRecordsAsync<Clinic>().ToListAsync();
            }
        }
    }
}
