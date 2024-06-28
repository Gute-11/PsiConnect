using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PsiConnect.Models;

namespace PsiConnect.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

            Database.SetCommandTimeout(60);
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Psicologos> Psicologos { get; set; }

        public DbSet<Prontuario> Prontuarios { get; set;}
    }
}
