using Microsoft.EntityFrameworkCore;
using ResidentBackEnd.Models;

namespace ResidentBackEnd.Data
{
    public class DataContextClass:DbContext
    {
        public DataContextClass(DbContextOptions<DataContextClass> options) : base(options)
        { }
        public DbSet<Apartment> tblApartments { get; set; }
        public DbSet<Complaint> tblcomplaints { get; set; }
        public DbSet<family> tblFamily { get; set; }
        public DbSet<EventRegcs> tblEventReg{ get; set; }



    }
}
