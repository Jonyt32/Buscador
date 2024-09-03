using Datos.Context;
using Datos.Interfaces;
using Datos.Repositorio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Negocio.interfaces;
using Negocio.Servicios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped(typeof(IRepositorioGenerico<>), typeof(RepositorioGenerico<>));
builder.Services.AddScoped(typeof(IRepositorioReserva), typeof(RepositorioReserva));
builder.Services.AddScoped<IServicioReserva, ServicioReserva>();
builder.Services.AddScoped<IServicioSede, ServicioSede>();
builder.Services.AddScoped<IServicioTipoAlojamiento, ServicioTipoAlojamiento>();
builder.Services.AddScoped<IServicioDisponibilidad, ServicioDisponibilidad>();
builder.Services.AddScoped<IServicioTarifa, ServicioTarifa>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
