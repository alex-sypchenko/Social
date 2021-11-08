namespace Social.Domain
{
    public class Likes : BaseEntity
    {
        public int UserId { get; set; }
        public UserProfile User { get; set; }
        public int PostId { get; set; }
        public Posts Post { get; set; }
    }
}
