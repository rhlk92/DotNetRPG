using Microsoft.EntityFrameworkCore;
using DotNetRPG.Models;

namespace DotNetRPG.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Character> Characters { get; set; }
    }
}