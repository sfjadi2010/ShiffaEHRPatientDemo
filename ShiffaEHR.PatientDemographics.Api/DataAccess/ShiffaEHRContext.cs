using Microsoft.EntityFrameworkCore;
using ShiffaEHR.PatientDemographics.Api.Models;

namespace ShiffaEHR.PatientDemographics.Api.DataAccess;

public class ShiffaEHRContext : DbContext
{
    public ShiffaEHRContext(DbContextOptions<ShiffaEHRContext> options) : base(options)
    {
    }
    public DbSet<Patient> Patients { get; set; } = default!;
    public DbSet<InsuranceProvider> InsuranceProviders { get; set; } = default!;
    public DbSet<Insurance> Insurances { get; set; } = default!;
}
