using System.ComponentModel.DataAnnotations;

namespace ResidentBackEnd.Models
{
    public class adminPanel
    {
        [Key]
        public int id { get; set; }
        public string? date { get; set; }
        public string? President { get; set; }
        public string? Secretary { get; set; }
        public string? Treasurer { get; set; }
    }
}
