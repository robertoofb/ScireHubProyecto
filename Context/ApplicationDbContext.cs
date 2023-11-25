using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ScireHub.Models.Entities;

namespace ScireHub.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public virtual DbSet<Usuario> Usuarios { get; set; }

    }
}
