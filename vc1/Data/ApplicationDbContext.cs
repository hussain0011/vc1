using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using vc1.Models;

namespace vc1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ArchivingModel> ArchivingTable { get; set; }
        public DbSet<StaffModel> StaffTable { get; set; }

    }
}