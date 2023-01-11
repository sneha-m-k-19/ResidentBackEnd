using System.ComponentModel.DataAnnotations;

namespace ResidentBackEnd.Models
{
    public class ComplaintView
    {
        [Key]
        public int id { get; set; }
        public string ApartmentNumber { get; set; }
        public string UserName { get; set; }
        public string ComplaintSubject { get; set; }
        public string Complaints { get; set; }
        public string status { get; set; }
    }
}
