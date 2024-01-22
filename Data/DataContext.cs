
using Microsoft.EntityFrameworkCore;
using api.Entities;

namespace api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Showroom> Showrooms { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<TreeDModel> TreeDModels { get; set; }
        public DbSet<Texture> Textures { get; set; }
        public DbSet<Wheel> Wheels { get; set; }
        public DbSet<Constructor> Constructors { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<api.Entities.Environment> Environments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .HasMany(c => c.Colors)
                .WithOne()
                .HasForeignKey(c => c.CarId);
        }
}}