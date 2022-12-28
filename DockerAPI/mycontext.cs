using Microsoft.EntityFrameworkCore;

namespace DockerAPI
{
   
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }
        }
    
}
