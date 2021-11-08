using Microsoft.EntityFrameworkCore;
using Social.Domain;
using System.Threading.Tasks;

namespace Social.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Comments> Comments { get; set; }
        public DbSet<Followers> Followers { get; set; }
        public DbSet<Likes> Likes { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<PostTags> PostTags { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("DataSource=app.db");
            }

        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
