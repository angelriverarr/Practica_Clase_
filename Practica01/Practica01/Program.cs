using Microsoft.EntityFrameworkCore;
using Practica01.Data;
using Practica01.Models;
using Practica01.Repository;
using Practica01.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.





builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AplicationDBContext>(options =>
options.UseSqlServer("Server=.;Database=PROGRAAPLICADA; TrustServerCertificate=true; Trusted_Connection=true;" +
" Connection Timeout= 30; Integrated Security=true; Persist Security Info= false; Encrypt= true;" +
" MultipleActiveResultSets=true;"));

//inyeccion de dependencia 
builder.Services.AddTransient<IEstudents, Students>();


var app = builder.Build();

builder.Services.AddControllersWithViews();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Estudents}/{action=index}/{id?}");

app.Run();
