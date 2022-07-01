using demosql4.Models;
using Microsoft.EntityFrameworkCore;

namespace demosql4.Data
{
    public class ResumeDbContext:DbContext
    {
        public ResumeDbContext(DbContextOptions<ResumeDbContext> options) : base(options)
        {

        }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Experience> Experiences { get; set; }
    }
}
