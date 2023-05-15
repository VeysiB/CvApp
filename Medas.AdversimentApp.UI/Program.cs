




using Medas.AdvertisementApp.Business.DependencyResolvers.Microsoft;
using Medas.AdvirsementApp.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


//builder.Services
//       .AddDbContext<AdvertisementContext>
//    (opt => opt.UseSqlServer(builder.Configuration
//                                   .GetConnectionString("Local")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDependencies(builder.Configuration);

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
