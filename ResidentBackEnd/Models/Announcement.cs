using System.ComponentModel.DataAnnotations;

namespace ResidentBackEnd.Models
{
    public class Announcement
    {
        [Key]
        public int id { get; set; }
        public string? date { get; set; }
        public string? Title { get; set; }
        public string? Subject { get; set; }
        
    }
}
