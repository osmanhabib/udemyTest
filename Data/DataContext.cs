using Microsoft.EntityFrameworkCore;
using testCore.Entities;

namespace testCore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> Users {get;set;}
    }
}