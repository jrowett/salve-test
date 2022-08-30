using SalveTest.Service.Contracts;
using SalveTest.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IClinicService, ClinicService>();
builder.Services.AddTransient<IPatientService, PatientService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/clinics", async (IClinicService clinics) =>
{
    return await clinics.GetClinicsAsync();
})
.WithName("GetClinics");

app.MapGet("/clinics/{id}/patients", async (int id, IPatientService patients) =>
{
    return await patients.GetPatientsForClinicAsync(id)
    is IEnumerable<Patient> result
       ? Results.Ok(result)
       : Results.NotFound();
})
.WithName("GetPatientsForClinic");

app.Run();