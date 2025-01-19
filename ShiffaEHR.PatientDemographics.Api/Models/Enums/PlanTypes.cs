using System.ComponentModel;

namespace ShiffaEHR.PatientDemographics.Api.Models.Enums;

/// <summary>
/// Enum representing different types of insurance plans.
/// </summary>
public enum PlanTypes
{
    /// <summary>
    /// Represents an in-network insurance plan.
    /// </summary>
    [Description("In-network insurance plan")]
    InNetwork = 1,

    /// <summary>
    /// Represents an out-of-network insurance plan.
    /// </summary>
    [Description("Out-of-network insurance plan")]
    OutOfNetwork = 2,

    /// <summary>
    /// Represents an unknown type of insurance plan.
    /// </summary>
    [Description("Unknown insurance plan")]
    Unknown = 3
}
