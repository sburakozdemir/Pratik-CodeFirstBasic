using Microsoft.EntityFrameworkCore;
using Pratik_CodeFirstBasic.Context;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

//3 b�y�klerin 3.s�
var connectionString = builder.Configuration.GetConnectionString("default");
builder.Services.AddDbContext<PatikaFirstDbContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();
