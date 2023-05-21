using Microsoft.EntityFrameworkCore;
using universidades.Models;

namespace universidades
{
    public class context:DbContext
    {
        public DbSet<Country>? country {get;set;}
     public DbSet<ranking_system>? ranking_System {get;set;}

  public DbSet<University>? University {get;set;}
 
        public context(DbContextOptions<context> options) : base(options){}
    }
}