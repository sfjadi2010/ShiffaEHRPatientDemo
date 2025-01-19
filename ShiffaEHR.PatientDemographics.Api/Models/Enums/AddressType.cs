using System.ComponentModel;

namespace ShiffaEHR.PatientDemographics.Api.Models.Enums;

/// <summary>
/// Specifies the type of address.
/// </summary>
public enum AddressType
{
    /// <summary>
    /// Home address.
    /// </summary>
    [Description("Home address")]
    Home = 1,

    /// <summary>
    /// Work address.
    /// </summary>
    [Description("Work address")]
    Work = 2,

    /// <summary>
    /// Billing address.
    /// </summary>
    [Description("Billing address")]
    Billing = 3,

    /// <summary>
    /// Shipping address.
    /// </summary>
    [Description("Shipping address")]
    Shipping = 4
}
