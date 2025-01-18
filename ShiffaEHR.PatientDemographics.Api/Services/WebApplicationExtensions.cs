using Microsoft.AspNetCore.Mvc;
using ShiffaEHR.PatientDemographics.Api.Models.Dtos;
using ShiffaEHR.PatientDemographics.Api.Services.Interfaces;

namespace ShiffaEHR.PatientDemographics.Api.Services;

public static class WebApplicationExtensions
{
    public static WebApplication GetMaps(this WebApplication app)
    {
        app.MapGet("/patients", async ([FromServices] IPatientService patientService) =>
        {
            return Results.Ok(await patientService.GetAllPatientsAsync());
        })
            .WithName("GetPatients");

        app.MapGet("/patients/{id}", async ([FromServices] IPatientService patientService, int id) =>
        {
            var patient = await patientService.GetPatientByIdAsync(id);

            if (patient is null)
            {
                return Results.NotFound();
            }
            return Results.Ok(patient);
        })
            .WithName("GetPatient");

        return app;
    }

    public static WebApplication PostMaps(this WebApplication app)
    {
        app.MapPost("/patients", async ([FromServices] IPatientService patientService, [FromBody] PatientDto patientDto) =>
        {
            var patient = await patientService.CreatePatientAsync(patientDto);
            return Results.Created($"/patients/{patient.Id}", patient);
        })
            .WithName("AddPatient");

        return app;
    }

    public static WebApplication DeletdMaps(this WebApplication app)
    {
        app.MapDelete("/patients/{id}", async ([FromServices] IPatientService patientService, int id) =>
        {
            await patientService.DeletePatientAsync(id);
        })
            .WithName("DeletePatient");

        return app;
    }

    public static WebApplication PutMaps(this WebApplication app)
    {
        app.MapPut("/patients/{id}", async ([FromServices] IPatientService patientService, int id, [FromBody] PatientDto patientDto) =>
        {
            var patient = await patientService.UpdatePatientAsync(id, patientDto);
            return Results.Ok(patient);
        })
            .WithName("UpdatePatient");

        return app;
    }
}
