using System.ComponentModel.DataAnnotations;

namespace Social.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
