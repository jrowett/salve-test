using CsvHelper.Configuration;
using SalveTest.Service.Contracts;

namespace SalveTest.Service.Services
{
    public class PatientMap : ClassMap<Patient>
    {
        public PatientMap()
        {
            Map(m => m.Id).Name("id");
            Map(m => m.FirstName).Name("first_name");
            Map(m => m.LastName).Name("last_name");
            Map(m => m.DateOfBirth).Name("date_of_birth");
        }
    }
}
