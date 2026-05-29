using Microsoft.EntityFrameworkCore;
using PC12410003323100833.CORE.Core.Interfaces;
using PC12410003323100833.CORE.Core.Services;
using PC12410003323100833.CORE.Infrastructure.Data;
using PC12410003323100833.CORE.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

var _config = builder.Configuration;
var cnx = _config.GetConnectionString("DevConnection");

builder.Services.AddDbContext<TallerMecanicoContext>(options =>
    options.UseSqlServer(cnx));

builder.Services.AddTransient<IOrdenServicioRepository, OrdenServicioRepository>();
builder.Services.AddTransient<IOrdenServicioService, OrdenServicioService>();

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();