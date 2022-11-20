using MeuCampeonatoAPI.Domain.Data.Context;
using Microsoft.EntityFrameworkCore;
using ShipShape.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(connectionString);
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddServices();
builder.Services.AddRepositories();

string corsPolicy = "corsPolicy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(corsPolicy,
                          policy =>
                          {
                              policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
                          });
});

var app = builder.Build();

//Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors(corsPolicy);

app.Run();