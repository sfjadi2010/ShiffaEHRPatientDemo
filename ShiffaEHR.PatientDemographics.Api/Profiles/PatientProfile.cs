using AutoMapper;

namespace ShiffaEHR.PatientDemographics.Api.Profiles;

public class PatientProfile : Profile
{
    public PatientProfile()
    {
        CreateMap<Models.Patient, Models.Dtos.PatientDto>().ReverseMap();
    }
}
