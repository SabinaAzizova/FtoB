
using Microsoft.EntityFrameworkCore;
using WebApplication2.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<AppDbContext>(opt => { opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")); }) ;


var app = builder.Build();



app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
