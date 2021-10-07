using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social
{
    class DatabaseFiller
    {
        public void FillingDatabese()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();

                UserProfile[] users = new UserProfile[5];
                users[0] = new UserProfile { Name = "user1" };
                users[1] = new UserProfile { Name = "user2" };
                users[2] = new UserProfile { Name = "user3" };
                users[3] = new UserProfile { Name = "user4" };
                users[4] = new UserProfile { Name = "user5" };

                Followers[] followers = new Followers[4];
                followers[0] = new Followers { ForWho = users[0], WhoFollow = users[1] };
                followers[1] = new Followers { ForWho = users[0], WhoFollow = users[2] };
                followers[2] = new Followers { ForWho = users[1], WhoFollow = users[0] };
                followers[3] = new Followers { ForWho = users[2], WhoFollow = users[0] };

                Tags[] tags = new Tags[3];
                tags[0] = new Tags { Tag = "tag1" };
                tags[1] = new Tags { Tag = "tag2" };
                tags[2] = new Tags { Tag = "tag3" };

                Posts[] posts = new Posts[3];
                posts[0] = new Posts { Name = "post1", Author = users[0], Description = "text1" };
                posts[1] = new Posts { Name = "post2", Author = users[1], Description = "text2" };
                posts[2] = new Posts { Name = "post3", Author = users[1], Description = "text3" };

                PostTags[] postTags = new PostTags[5];
                postTags[0] = new PostTags { Tag = tags[0], Post = posts[0] };
                postTags[1] = new PostTags { Tag = tags[1], Post = posts[0] };
                postTags[2] = new PostTags { Tag = tags[1], Post = posts[1] };
                postTags[3] = new PostTags { Tag = tags[2], Post = posts[1] };
                postTags[4] = new PostTags { Tag = tags[2], Post = posts[2] };

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
