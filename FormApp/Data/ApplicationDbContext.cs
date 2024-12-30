using FormApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FormApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
     : base(options)
        {
        }
        public DbSet<CMRAFormModel> CMRAFormModels { get; set; }
    }
}
