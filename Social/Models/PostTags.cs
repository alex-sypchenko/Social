namespace Social
{
    public class PostTags
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public Tags Tag { get; set; }
        public int PostId { get; set; }
        public Posts Post { get; set; }
    }
}
