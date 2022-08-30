using CsvHelper.Configuration;
using SalveTest.Service.Contracts;

namespace SalveTest.Service.Services
{
    public class ClinicMap : ClassMap<Clinic>
    {
        public ClinicMap()
        {
            Map(m => m.Id).Name("id");
            Map(m => m.Name).Name("name");
        }
    }
}
