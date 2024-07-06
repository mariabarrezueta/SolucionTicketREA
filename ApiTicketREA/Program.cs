using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ApiTicketREA.Data;
using ApiTicketREA.Data.Models;

var builder = WebApplication.CreateBuilder(args);

// Configuración del contexto de la base de datos
builder.Services.AddDbContext<ApiTicketREAContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ApiTicketREAContext") ?? throw new InvalidOperationException("Connection string 'ApiTicketREAContext' not found.")));

// Configuración de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

// Agregar servicios al contenedor.
builder.Services.AddControllers();

// Configuración de Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "ApiTick", Version = "v1" });
});

var app = builder.Build();

// Configuración del pipeline de solicitudes HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiTick v1"));
}

app.UseHttpsRedirection();
app.UseAuthorization();

// Aplicar CORS
app.UseCors("AllowAllOrigins");

app.MapControllers();

app.Run();


