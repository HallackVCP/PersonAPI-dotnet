using Microsoft.EntityFrameworkCore;
using RestASPNET.Model;

namespace RestASPNET.Persistence;

public class Context: DbContext
{
    public Context(DbContextOptions<Context> options) :base(options)
    {
        
    }
    
    public DbSet<Person> Persons { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>(e =>
        {
            e.HasKey(e => e.Id);
        });
        base.OnModelCreating(modelBuilder);
    }
}