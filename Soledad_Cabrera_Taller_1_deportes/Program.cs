using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Soledad_Cabrera_Taller_1_deportes.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Soledad_Cabrera_Taller_1_deportesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Soledad_Cabrera_Taller_1_deportesContext") ?? throw new InvalidOperationException("Connection string 'Soledad_Cabrera_Taller_1_deportesContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
