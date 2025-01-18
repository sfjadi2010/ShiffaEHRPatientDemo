using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using ShiffaEHR.PatientDemographics.Api.DataAccess;
using ShiffaEHR.PatientDemographics.Api.Services;
using ShiffaEHR.PatientDemographics.Api.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// add auto mapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<ShiffaEHRContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// add scoped services
builder.Services.AddScoped<IPatientService, PatientService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.GetMaps();
app.PostMaps();
app.DeletdMaps();
app.PutMaps();

app.Run();
