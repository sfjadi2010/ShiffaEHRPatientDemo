using Microsoft.EntityFrameworkCore;

namespace ShiffaEHR.PatientDemographics.Api.DataAccess;

public class ShiffaEHRContext : DbContext
{
    public ShiffaEHRContext(DbContextOptions<ShiffaEHRContext> options) : base(options)
    {
    }
    public DbSet<Models.Patient> Patients { get; set; } = default!;
}
