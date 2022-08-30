using SalveTest.Service.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/clinics", () =>
{
    return new[]
    {
        new Clinic {Id = 1, Name = "Test Clinic 1"},
        new Clinic {Id = 2, Name = "Test Clinic 2"}
    };
})
.WithName("GetClinics");

app.MapGet("/clinics/{id}/patients", (int id) =>
{
    return new[]
    {
        new Patient {Id = 1, FirstName = "Joe", LastName = "Bloggs", DateOfBirth = DateTime.Now.AddYears(-40).Date},
         new Patient {Id = 2, FirstName = "Jane", LastName = "Bloggs", DateOfBirth = DateTime.Now.AddYears(-40).Date}
    };
})
.WithName("GetPatientsForClinic");

app.Run();