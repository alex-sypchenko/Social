using System.Collections.Generic;

namespace Social
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }

        public List<Posts> Posts { get; set; } = new List<Posts>();
        public List<Comments> Comments { get; set; } = new List<Comments>();
        public List<Likes> Likes { get; set; } = new List<Likes>();
    }
}
