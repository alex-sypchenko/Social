namespace Social.Domain
{
    public class PostTags : BaseEntity
    {
        public int TagId { get; set; }
        public Tags Tag { get; set; }
        public int PostId { get; set; }
        public Posts Post { get; set; }
    }
}
