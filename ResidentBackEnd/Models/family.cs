using System.ComponentModel.DataAnnotations;

namespace ResidentBackEnd.Models
{
    public class family
    {

        [Key]
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string inlineRadioOptions { get; set; }
        public string dob { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Occupation { get; set; }
        public string ApartmentNumber { get; set; }
        public string ApartmentName { get; set; }
    }
}
