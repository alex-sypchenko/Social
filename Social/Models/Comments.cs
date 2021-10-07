namespace Social
{
    public class Comments
    {
        public int Id { get; set; }
        public UserProfile Author { get; set; }
        public string Text { get; set; }

        public int PostId { get; set; }
        public Posts Post { get; set; }
    }
}
