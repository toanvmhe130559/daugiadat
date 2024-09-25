using Microsoft.EntityFrameworkCore;
using RealEstateAuction.Business.Services.Implements;
using RealEstateAuction.Business.Services.Interface;
using RealEstateAuction.Data.EntityModels;
using RealEstateAuction.Data.Repositories.Implements;
using RealEstateAuction.Data.Repositories.Interface;

var builder = WebApplication.CreateBuilder(args);

// Configure services for DI, including DbContext
builder.Services.AddDbContext<RealEstateContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register for business services
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();

// Register for repositories
builder.Services.AddScoped<IUserRepository, UserRepository>();

// Register Automapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
