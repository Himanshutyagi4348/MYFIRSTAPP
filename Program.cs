using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MYFIRSTAPP.Context;
using MYFIRSTAPP.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<Iemployeerepository,EmployeeRepository>();
//builder.Services.AddScoped<Appdbcontext, Appdbcontext>();

builder.Services.AddScoped<Iemployeerepository, SQLRepository>();

builder.Services.AddDbContext<Appdbcontext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
//builder.Services.AddScoped<Appdbcontext,Appdbcontext>();
var app = builder.Build();

// Configure the HTTP request pipeline. 
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=EmployeeController1}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
