




using AutoMapper;
using FluentValidation;
using Medas.AdversimentApp.UI.Mapping;
using Medas.AdversimentApp.UI.Models;
using Medas.AdversimentApp.UI.ValidationRules;
using Medas.AdvertisementApp.Business.DependencyResolvers.Microsoft;
using Medas.AdvertisementApp.Business.Helpers;
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
builder.Services.AddTransient<IValidator<UserCreateModel>,UserCreateModelValidator>();
var profiles=ProfileHelper.GetProfiles();
profiles.Add(new UserCreateModelProfile());

var configuration = new MapperConfiguration(opt =>
{
    opt.AddProfiles(profiles);
});
var mapper=configuration.CreateMapper();
builder.Services.AddSingleton(mapper);


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
