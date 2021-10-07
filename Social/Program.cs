using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Social
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseFiller filler = new DatabaseFiller();
            filler.FillingDatabese();

            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.UserProfiles.ToList();
                Console.WriteLine("Список пользователей:");
                foreach (UserProfile u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name}");
                }

                Console.WriteLine("Список подписчиков пользователя 0:");
                var followers = Query.UserFollowers.GetFollowers(db.UserProfiles.FirstOrDefault());
                if(followers != null)
                {
                    foreach (UserProfile u in followers)
                    {
                        Console.WriteLine($"{u.Id}.{u.Name}");
                    }
                }
            }

            using (ApplicationContext db = new ApplicationContext())
            {
                int datei = 1;
                string dates = "1";
                var postlist = db.Followers.Where(x => x.WhoFollowId == datei);
                var users = db.Posts.Where(p => EF.Functions.Like(p.Name, "%" + dates + "%")); //поиск по заголовку

            }

            Console.Read();
        }
    }
}
