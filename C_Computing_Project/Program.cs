using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using C_Computing_Project.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<C_Computing_ProjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("C_Computing_ProjectContext") ?? throw new InvalidOperationException("Connection string 'C_Computing_ProjectContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Recipes}/{action=Index}/{id?}");

app.Run();
