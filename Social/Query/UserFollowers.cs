using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Social.Query
{
    class UserFollowers
    {
        static public IQueryable GetFollowers(UserProfile user)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Followers.Include(p => p.WhoFollow).Where(x => x.ForWhoId == user.Id);
            }
        }
    }
}
