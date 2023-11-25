using Microsoft.EntityFrameworkCore;

namespace ScireHub.Migration
{
    public class ApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
