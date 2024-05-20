using Microsoft.EntityFrameworkCore;
using PsiConnect.Models;

namespace PsiConnect.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Psicologos> Psicologos { get; set; }

    }
}
