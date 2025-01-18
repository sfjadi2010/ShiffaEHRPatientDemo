using ShiffaEHR.PatientDemographics.Api.Models.Enums;

namespace ShiffaEHR.PatientDemographics.Api.Models.Dtos;

public class PatientDto
{
    public int Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string Lastname { get; set; } = default!;
    public DateOnly DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public string PhoneNumber { get; set; } = default!;
    public string Email { get; set; } = default!;
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
