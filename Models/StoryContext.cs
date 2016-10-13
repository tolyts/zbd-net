using Microsoft.EntityFrameworkCore;
namespace zbd_net.Models {    
    public class StoryContext : DbContext  
    {
        public StoryContext(DbContextOptions<StoryContext> options)
            : base(options)
        { }

        public DbSet<Story__c> story__c { get; set; }        
        
    }

    
}