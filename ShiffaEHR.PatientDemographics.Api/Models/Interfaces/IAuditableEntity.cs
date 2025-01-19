namespace ShiffaEHR.PatientDemographics.Api.Models.Interfaces;

/// <summary>
/// Interface for auditable entities, providing properties for creation and update timestamps.
/// </summary>
public interface IAuditableEntity
{
    /// <summary>
    /// Gets or sets the date and time when the entity was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the entity was last updated.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }
}
