using Microsoft.EntityFrameworkCore;
using Pratik_CodeFirstBasic.Context;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

//3 büyüklerin 3.sü
var connectionString = builder.Configuration.GetConnectionString("default");
builder.Services.AddDbContext<PatikaFirstDbContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();
