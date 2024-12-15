using Microsoft.EntityFrameworkCore;
using TaskManager.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=tasks.db")
           .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information));


builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Task}/{action=Index}/{id?}");

app.Run();