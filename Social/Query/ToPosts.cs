using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Social.Query
{
    class ToPosts
    {
        public static List<Posts> SearchByPostTitle(string text)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Posts.Where(p => EF.Functions.Like(p.Name, "%" + text + "%")).ToList();
            }
        }

        public static int AmountLikes(Posts post)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Likes.Where(p => p.PostId == post.Id).Count();
            }
        }

        public static string SearchPostWithTag(string text)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.PostTags.Include(p => p.Tag).Include(p => p.Post).Where(p => p.Tag.Tag == text).Select(p => p.Post).ToQueryString();
            }
        }
    }
}
