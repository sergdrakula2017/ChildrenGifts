using System.Runtime.CompilerServices;
using ChildrenGifts.Data;
using Microsoft.EntityFrameworkCore;

namespace ChildrenGifts.Client;

public class Program
{
    public static async Task Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);


        string str = Environment.CurrentDirectory;
        builder.Services.AddDbContextPool<ChildContext>(x => x.UseSqlite("Data Source=data.sqlite;"));

        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();

        WebApplication app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment()) app.UseExceptionHandler("/Error");


        app.UseStaticFiles();

        app.UseRouting();

        app.MapBlazorHub();
        app.MapFallbackToPage("/_Host");

        IServiceScopeFactory scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
        AsyncServiceScope scope = scopeFactory.CreateAsyncScope();
        await using (ConfiguredAsyncDisposable _ = scope.ConfigureAwait(false))
        {
            ChildContext context = scope.ServiceProvider.GetRequiredService<ChildContext>();
            await context.Database.MigrateAsync().ConfigureAwait(false);
        }

        await app.RunAsync();
    }
}