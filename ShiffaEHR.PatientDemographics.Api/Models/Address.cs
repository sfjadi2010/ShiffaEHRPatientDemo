using ShiffaEHR.PatientDemographics.Api.Models.Enums;
using ShiffaEHR.PatientDemographics.Api.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ShiffaEHR.PatientDemographics.Api.Models;

public class Address : IAuditableEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string StreetLine1 { get; set; } = default!;

    public string? StreetLine2 { get; set; }

    [Required]
    [StringLength(50)]
    public string City { get; set; } = default!;

    [Required]
    [StringLength(50)]
    public string State { get; set; } = default!;

    public string ZipCode { get; set; } = default!;

    public string Country { get; set; } = default!;

    public AddressType Type { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
