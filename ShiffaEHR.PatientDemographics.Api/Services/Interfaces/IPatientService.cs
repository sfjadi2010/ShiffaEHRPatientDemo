using ShiffaEHR.PatientDemographics.Api.Models.Dtos;

namespace ShiffaEHR.PatientDemographics.Api.Services.Interfaces;

public interface IPatientService
{
    Task<PatientDto> CreatePatientAsync(PatientDto patientDto);
    Task<IEnumerable<PatientDto>> GetAllPatientsAsync();
    Task<PatientDto?> GetPatientByIdAsync(int Id);
    Task DeletePatientAsync(int id);
    Task<PatientDto> UpdatePatientAsync(int id, PatientDto patientDto);

}
