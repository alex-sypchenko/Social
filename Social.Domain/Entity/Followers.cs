using System.ComponentModel.DataAnnotations.Schema;

namespace Social.Domain
{
    public class Followers : BaseEntity
    {
        public int? ForWhoId { get; set; }
        public UserProfile ForWho { get; set; }
        public int WhoFollowId { get; set; }
        public UserProfile WhoFollow { get; set; }
    }
}
