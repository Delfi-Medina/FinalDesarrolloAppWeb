using FinalDesarrolloAppWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalDesarrolloAppWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
            
        }

        public DbSet<Gasto> Gastos { get; set; }

    }
}
