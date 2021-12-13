using System.Collections.Generic;

namespace Social.Domain
{
    public class UserProfile : BaseEntity
    {
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public List<Posts> Posts { get; set; } = new List<Posts>();
        public List<Comments> Comments { get; set; } = new List<Comments>();
        public List<Likes> Likes { get; set; } = new List<Likes>();
    }
}
