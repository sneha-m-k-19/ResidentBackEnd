using System.ComponentModel.DataAnnotations;

namespace ResidentBackEnd.Models
{
    public class Payment
    {
        [Key]
        public int id { get; set; }
        public string ApartmentNumber { get; set; }
        public string UserName { get; set; }
        public string Event { get; set; }
        public string Paymentamt { get; set; }
        public string date { get; set; }

    }
}
