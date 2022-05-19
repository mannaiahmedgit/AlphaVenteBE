using AlphaVenteApi.Data;
using AlphaVenteApi.repositories;
using AlphaVenteApi.Services;
using AlphaVenteApi.unitOfWork;
using AlphaVenteData.interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//recupereation connextionString
var connectionString = builder.Configuration.GetConnectionString("aplhe_vente_cnx");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//enregistrement dbContext
builder.Services.AddDbContext<AlphaDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddAutoMapper(   typeof(MappingProfile).Assembly);
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IServiceGeneric<,>), typeof(ServiceGeneric<,>));
builder.Services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
//builder.Services.AddAllService();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
