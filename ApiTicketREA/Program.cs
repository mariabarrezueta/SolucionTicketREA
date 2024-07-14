using Microsoft.EntityFrameworkCore;
using ApiTicketREA.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<REAbaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("REAbaseContext")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Agregar servicio CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Configurar CORS en el middleware
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
