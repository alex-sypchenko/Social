using System;
using Social.Domain;

namespace Social.Persistence
{
    class DatabaseFiller
    {
        public void FillingDatabese()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                UserProfile[] users = new UserProfile[5];
                users[0] = new UserProfile { Name = "user1", Login = "user1", Password = "user11" };
                users[1] = new UserProfile { Name = "user2", Login = "user2", Password = "user22" };
                users[2] = new UserProfile { Name = "user3", Login = "user3", Password = "user33" };
                users[3] = new UserProfile { Name = "user4", Login = "user4", Password = "user44" };
                users[4] = new UserProfile { Name = "user5", Login = "user5", Password = "user55" };

                Followers[] followers = new Followers[4];
                followers[0] = new Followers { ForWho = users[0], WhoFollow = users[1] };
                followers[1] = new Followers { ForWho = users[0], WhoFollow = users[2] };
                followers[2] = new Followers { ForWho = users[1], WhoFollow = users[0] };
                followers[3] = new Followers { ForWho = users[2], WhoFollow = users[0] };

                Tags[] tags = new Tags[1000];
                tags[0] = new Tags { Tag = "tag1" };
                tags[1] = new Tags { Tag = "tag2" };
                tags[2] = new Tags { Tag = "tag3" };
                for(int i = 3; i < 1000; i++)
                {
                    tags[i] = new Tags { Tag = $"tag{i}" };
                }
                

                Posts[] posts = new Posts[3];
                posts[0] = new Posts { Name = "post1", Author = users[0], Description = "text1" };
                posts[1] = new Posts { Name = "post2", Author = users[1], Description = "text2" };
                posts[2] = new Posts { Name = "post3", Author = users[1], Description = "text3" };

                PostTags[] postTags = new PostTags[1000];
                postTags[0] = new PostTags { Tag = tags[0], Post = posts[0] };
                postTags[1] = new PostTags { Tag = tags[1], Post = posts[0] };
                postTags[2] = new PostTags { Tag = tags[1], Post = posts[1] };
                postTags[3] = new PostTags { Tag = tags[2], Post = posts[1] };
                postTags[4] = new PostTags { Tag = tags[2], Post = posts[2] };
                for (int i = 5; i < 500; i++)
                {
                    postTags[i] = new PostTags { Tag = tags[i], Post = posts[2] };
                }
                for (int i = 500; i < 1000; i++)
                {
                    postTags[i] = new PostTags { Tag = tags[i], Post = posts[1] };
                }


                Comments[] comments = new Comments[6];
                comments[0] = new Comments { Post = posts[0], Author = users[1], Text = "comment1" };
                comments[1] = new Comments { Post = posts[1], Author = users[2], Text = "comment2" };
                comments[2] = new Comments { Post = posts[1], Author = users[3], Text = "comment3" };
                comments[3] = new Comments { Post = posts[2], Author = users[0], Text = "comment4" };
                comments[4] = new Comments { Post = posts[2], Author = users[1], Text = "comment5" };
                comments[5] = new Comments { Post = posts[2], Author = users[4], Text = "comment6" };

                Likes[] likes = new Likes[5];
                likes[0] = new Likes { Post = posts[0], User = users[1] };
                likes[1] = new Likes { Post = posts[1], User = users[0] };
                likes[2] = new Likes { Post = posts[1], User = users[2] };
                likes[3] = new Likes { Post = posts[2], User = users[3] };
                likes[4] = new Likes { Post = posts[2], User = users[2] };

                db.UserProfiles.AddRange(users);
                db.Followers.AddRange(followers);
                db.Tags.AddRange(tags);
                db.Posts.AddRange(posts);
                db.PostTags.AddRange(postTags);
                db.Comments.AddRange(comments);
                db.Likes.AddRange(likes);
                db.SaveChanges();
                Console.WriteLine("База успешно наполненна данными");
            }
        }
    }
}
