using ShiffaEHR.PatientDemographics.Api.Models.Enums;
using ShiffaEHR.PatientDemographics.Api.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ShiffaEHR.PatientDemographics.Api.Models;

public class InsuranceProvider : IAuditableEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = default!;

    public string? ContactPhone { get; set; }

    public string? ContactEmail { get; set; }

    public Address Address { get; set; } = default!;

    public PlanTypes Types { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
