using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq;

namespace Social.Query
{
    class SearchByPostTitle
    {
        public static IList GetPosts(string text)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Posts.Where(p => EF.Functions.Like(p.Name, "%" + text + "%")).ToList();
            }
        }
    }
}
