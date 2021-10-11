using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Social.Query
{
    class ToUsers
    {
        static public List<Followers> GetFollowers(UserProfile user)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Followers.Include(p => p.WhoFollow).Where(x => x.ForWhoId == user.Id).ToList();
            }
        }

        static public List<Followers> GetSubscriptions(UserProfile user)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Followers.Include(p => p.ForWho).Where(x => x.WhoFollowId == user.Id).ToList();
            }
        }

        static public List<Likes> GetLikesPost(Posts post)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Likes.Include(p => p.Post).Where(x => x.PostId == post.Id).ToList();
            }
        }
    }
}
