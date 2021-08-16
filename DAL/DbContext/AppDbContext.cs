using System.Data.Entity;
using DAL.Entities;

namespace DAL.DbContextN
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base(@"Server=.;Database=LaughingPalmTreeDB;Trusted_Connection=True;")
        {
        }

        public DbSet<Good> Goods { get; set; }
        public DbSet<Bucket> Buckets { get; set; }
    }
}
