using CutomilyNetCoreTest;
using CutomilyNetCoreTest.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("AppDb");
builder.Services.AddDbContext<PagesDbContext>(x => x.UseSqlServer(connectionString));

builder.Services.AddScoped<IPageService, PageService>();


builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
