using Microsoft.EntityFrameworkCore;
namespace zbd_net.Models {    
    public class ContactContext : DbContext  
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }

        public DbSet<Contact> contact { get; set; }

        
    }

    
}