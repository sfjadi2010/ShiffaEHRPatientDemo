using ShiffaEHR.PatientDemographics.Api.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ShiffaEHR.PatientDemographics.Api.Models;

public class Insurance : IAuditableEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string PolicyNumber { get; set; } = default!;

    [Required]
    public string GroupNumber { get; set; } = default!;

    public string PlanType { get; set; } = default!;

    public int InsuranceProviderId { get; set; }

    public virtual InsuranceProvider InsuranceProvider { get; set; } = default!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
