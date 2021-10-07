using System.Collections.Generic;

namespace Social
{
    public class Posts
    {
        public int Id { get; set; }
        public UserProfile Author { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }

        public List<PostTags> PostTags { get; set; } = new List<PostTags>();
        public List<Comments> Comments { get; set; } = new List<Comments>();
    }
}
