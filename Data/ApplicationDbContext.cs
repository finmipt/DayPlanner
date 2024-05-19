using Microsoft.EntityFrameworkCore;
using DayPlanner.Models; // Ensure this is correctly pointing to where your Activity model is defined

namespace DayPlanner.Data
{
    public class ApplicationDbContext : DbContext // Correct inheritance
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; } // Correctly defined DbSet
    }
}



