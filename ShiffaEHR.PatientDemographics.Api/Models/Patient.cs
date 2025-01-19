using ShiffaEHR.PatientDemographics.Api.Models.Enums;
using ShiffaEHR.PatientDemographics.Api.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ShiffaEHR.PatientDemographics.Api.Models;

public class Patient : IAuditableEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string FirstName { get; set; } = default!;

    [Required]
    [StringLength(50)]
    public string Lastname { get; set; } = default!;

    [Required]
    public DateOnly DateOfBirth { get; set; }

    public DateOnly? DateOfDeath { get; set; }

    public Gender Gender { get; set; }

    public string PhoneNumber { get; set; } = default!;

    public string Email { get; set; } = default!;

    public string? SocialSecurityNumber { get; set; } = default!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
