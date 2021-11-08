using Microsoft.EntityFrameworkCore;
using Social.Domain;
using System.Threading.Tasks;

namespace Social.Persistence
{
    public interface IApplicationDbContext
    {
        DbSet<Comments> Comments { get; set; }
        DbSet<Followers> Followers { get; set; }
        DbSet<Likes> Likes { get; set; }
        DbSet<Posts> Posts { get; set; }
        DbSet<PostTags> PostTags { get; set; }
        DbSet<Tags> Tags { get; set; }
        DbSet<UserProfile> UserProfiles { get; set; }

        Task<int> SaveChangesAsync();
    }
}
