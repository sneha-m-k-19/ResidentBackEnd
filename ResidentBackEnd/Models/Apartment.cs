using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace ResidentBackEnd.Models
{
    public class Apartment
    {
        [Key]
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string ApartmentName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
