using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Social.Query
{
    class UserSubscriptions
    {
        static public IQueryable GetSubscriptions(UserProfile user)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Followers.Include(p => p.ForWho).Where(x => x.WhoFollowId == user.Id);
            }
        }
    }
}
