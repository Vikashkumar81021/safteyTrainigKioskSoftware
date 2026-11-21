using Microsoft.EntityFrameworkCore;
using Safety_Training_Kiosk_Software.Models;

namespace Safety_Training_Kiosk_Software.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
    }
}