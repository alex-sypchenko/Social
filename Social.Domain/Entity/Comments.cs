namespace Social.Domain
{
    public class Comments : BaseEntity
    {
        public UserProfile Author { get; set; }
        public string Text { get; set; }

        public int PostId { get; set; }
        public Posts Post { get; set; }
    }
}
