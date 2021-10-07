namespace Social
{
    public class Likes
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserProfile User { get; set; }
        public int PostId { get; set; }
        public Posts Post { get; set; }
    }
}
