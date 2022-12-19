using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;


namespace Domain.Data
{
    public class DirectoryDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-J37MVVO\SQLSERVER2019;Initial Catalog=Directory;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasKey(x => x.Id);
            modelBuilder.Entity<Person>().Property(x => x.MobilePhone).IsRequired(false);
            modelBuilder.Entity<Person>().Property(x => x.HomePhone).IsRequired(false);
            modelBuilder.Entity<Person>().HasIndex(x => new { x.MobilePhone, x.HomePhone }).IsUnique();
        }

        public DbSet<Person> Person { get; set; }
    }
}
