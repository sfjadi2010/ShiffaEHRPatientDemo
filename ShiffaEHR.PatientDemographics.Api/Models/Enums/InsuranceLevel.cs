using System.ComponentModel;

namespace ShiffaEHR.PatientDemographics.Api.Models.Enums;

/// <summary>
/// Represents the level of insurance coverage.
/// </summary>
public enum InsuranceLevel
{
    /// <summary>
    /// Primary insurance coverage.
    /// </summary>
    [Description("Primary insurance coverage")]
    Primary = 1,

    /// <summary>
    /// Secondary insurance coverage.
    /// </summary>
    [Description("Secondary insurance coverage")]
    Secondary = 2,

    /// <summary>
    /// Tertiary insurance coverage.
    /// </summary>
    [Description("Tertiary insurance coverage")]
    Tertiary = 3
}
