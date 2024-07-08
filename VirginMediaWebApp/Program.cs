using Repository.Base;
using Repository.Configuration;
using Repository.DataClass.Abstraction.CatalogueData;
using Repository.DataClass;
using Service.Abstraction;
using Service.Class;
using Service.Configuration;
using VirginMediaWebApp.Config;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped(typeof(ICatalogueData), typeof(CatalogueData));
builder.Services.AddScoped(typeof(ICatalogueService), typeof(CatalogueService));

builder.Services.AddAutoMapper(typeof(AutoMapperRepositoryConfig));
builder.Services.AddAutoMapper(typeof(AutoMapperServiceConfig));
builder.Services.AddAutoMapper(typeof(AutoMapperConfigWeb));


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
