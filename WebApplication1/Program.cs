using Repository.Base;
using Repository.DataClass.Abstraction.CatalogueData;
using Repository.DataClass;
using Service.Abstraction;
using Service.Class;
using Repository.Configuration;
using Service.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped(typeof(ICatalogueData), typeof(CatalogueData));
builder.Services.AddScoped(typeof(ICatalogueService), typeof(CatalogueService));

builder.Services.AddAutoMapper(typeof(AutoMapperRepositoryConfig));
builder.Services.AddAutoMapper(typeof(AutoMapperServiceConfig));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
