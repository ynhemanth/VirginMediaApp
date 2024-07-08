using Repository.Base;
using Repository.Configuration;
using Repository.DataClass;
using Repository.DataClass.Abstraction.CatalogueData;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped(typeof(ICatalogueData), typeof(CatalogueData));


builder.Services.AddAutoMapper(typeof(AutoMapperRepositoryConfig));


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
