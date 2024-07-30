using ContactManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManagementAPI.Data;

public class ContactDbContext : DbContext
{

    public ContactDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<ManagerName> ManagerNames { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<ManagerName>()
            .HasMany(p => p.Contacts)
            .WithOne(a => a.ManagerName)
            .HasForeignKey(b => b.ManagerNameId);
    }
}