using Microsoft.EntityFrameworkCore;

namespace Social
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Followers> Followers { get; set; }
        public DbSet<Likes> Likes { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<PostTags> PostTags { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        public ApplicationContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=socialappdb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
