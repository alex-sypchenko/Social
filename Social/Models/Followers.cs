using System.ComponentModel.DataAnnotations.Schema;

namespace Social
{
    public class Followers
    {
        public int Id { get; set; }
        public int? ForWhoId { get; set; }
        public UserProfile ForWho { get; set; }
        public int WhoFollowId { get; set; }
        public UserProfile WhoFollow { get; set; }
    }
}
