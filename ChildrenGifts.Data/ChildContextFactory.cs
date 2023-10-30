using ChildrenGifts.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace OfficesATM.Data;

public class ChildContextFactory : IDesignTimeDbContextFactory<ChildContext>
{
    public ChildContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<ChildContext> builder = new();
        string connectionString = args.Any()
            ? string.Join(' ', args)
            : "Data Source=data.sqlite;";
        Console.WriteLine(@"connectionString = " + connectionString);
        return new(builder
            .UseSqlite(connectionString)
            .Options);
    }
}