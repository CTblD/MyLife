using System.ComponentModel.DataAnnotations;

namespace MyLife.Models
{
    public class AppUser
    {
        [Key]
        public string? Id { get; set; }
        public int? Pace { get; set; }
        public int? Milage { get; set; }
        public Address? Address { get; set; }

    }
}
