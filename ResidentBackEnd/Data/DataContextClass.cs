using Microsoft.EntityFrameworkCore;
using ResidentBackEnd.Models;

namespace ResidentBackEnd.Data
{
    public class DataContextClass:DbContext
    {
        public DataContextClass(DbContextOptions<DataContextClass> options) : base(options)
        { }
        public DbSet<Apartment> tblApartments { get; set; }
        
        public DbSet<family> tblFamily { get; set; }
        public DbSet<EventRegcs> tblEventReg{ get; set; }

        public DbSet<ComplaintView> tblcomplaint { get; set; }
        public DbSet<Announcement> tblNotice { get; set; }
              
        public DbSet<Expense> tblDeduction { get; set; }

        public DbSet<Payment> tblIncome { get; set; }
        public DbSet<adminPanel> tblPanel { get; set; }


    }
}
