using DATA;
using Microsoft.EntityFrameworkCore;
using MODELOS.ENTIDADES;
using REPOSITORIOS;
using SERVICIOS.Interfaces;
using SERVICIOS;
using UTILITIES;
using REPOSITORIOS.INTERFACES;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddTransient(typeof(IRepoGeneric<>), typeof(RepoGeneric<>));


builder.Services.AddScoped<IRepoProducto, RepoProducto>();
builder.Services.AddScoped<IProductoServicio, ProductoServicio>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

    try
    {
        if (dbContext.Database.CanConnect())
        {
            logger.LogInformation("Conexión a la base de datos establecida correctamente.");
        }
        else
        {
            logger.LogError("No se pudo establecer la conexión a la base de datos.");
        }
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "Ocurrió un error al intentar conectar con la base de datos.");
    }
}


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
