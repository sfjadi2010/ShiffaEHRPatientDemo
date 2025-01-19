using System.ComponentModel;

namespace ShiffaEHR.PatientDemographics.Api.Models.Enums;

/// <summary>
/// Represents the gender of a patient.
/// </summary>
public enum Gender
{
    /// <summary>
    /// Male gender.
    /// </summary>
    [Description("Male gender")]
    Male = 1,

    /// <summary>
    /// Female gender.
    /// </summary>
    [Description("Female gender")]
    Female = 2,

    /// <summary>
    /// Other gender.
    /// </summary>
    [Description("Other gender")]
    Other = 3
}
