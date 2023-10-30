using ChildrenGifts.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ChildrenGifts.Data;

public class ChildContext : DbContext
{
    public ChildContext(DbContextOptions<ChildContext> options) : base(options)
    {
    }

    public DbSet<DbChild> Children { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<DbChild>(entity =>
        {
            entity.HasKey(x => x.Id);

            entity.HasIndex(x => x.Id);
            entity.HasIndex(x => x.Type);
            entity.HasIndex(x => x.FormDate);
        });
    }
}