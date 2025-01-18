namespace ShiffaEHR.PatientDemographics.Api.Models.Interfaces;

public interface IAuditableEntity
{
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
