using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShiffaEHR.PatientDemographics.Api.DataAccess;
using ShiffaEHR.PatientDemographics.Api.Models;
using ShiffaEHR.PatientDemographics.Api.Models.Dtos;
using ShiffaEHR.PatientDemographics.Api.Services.Interfaces;

namespace ShiffaEHR.PatientDemographics.Api.Services;

public class PatientService(ShiffaEHRContext ehrContext, IMapper mapper) : IPatientService
{
    public async Task<IEnumerable<PatientDto>> GetAllPatientsAsync()
    {
        return await ehrContext
                        .Patients
                        .Select(p => mapper.Map<PatientDto>(p))
                        .ToListAsync<PatientDto>();
    }

    public async Task<PatientDto?> GetPatientByIdAsync(int Id)
    {
        return await ehrContext
                        .Patients
                        .AsNoTracking()
                        .Where(p => p.Id == Id)
                        .Select(p => mapper.Map<PatientDto>(p))
                        .FirstOrDefaultAsync<PatientDto>();
    }

    public async Task<PatientDto> CreatePatientAsync(PatientDto patientDto)
    {
        var patient = mapper.Map<Patient>(patientDto);
        await ehrContext.Patients.AddAsync(patient);
        await ehrContext.SaveChangesAsync();
        return mapper.Map<PatientDto>(patient);
    }

    public async Task DeletePatientAsync(int id)
    {
        var patient = await ehrContext.Patients.FindAsync(id);

        if (patient is not null)
        {
            ehrContext.Patients.Remove(patient);
            await ehrContext.SaveChangesAsync();
        }
    }

    public async Task<PatientDto> UpdatePatientAsync(int id, PatientDto patientDto)
    {
        var patient = await ehrContext.Patients.FindAsync(id);
        if (patient is not null)
        {
            mapper.Map(patientDto, patient);
            await ehrContext.SaveChangesAsync();
        }
        return mapper.Map<PatientDto>(patient);
    }
}
