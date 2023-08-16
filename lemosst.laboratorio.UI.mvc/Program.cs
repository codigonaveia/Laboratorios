using lemosst.laboratorio.Data.Contexto;
using lemosst.laboratorio.Data.Repositorios;
using lemosst.laboratorio.Domain.Interfaces;
using lemosst.laboratorio.Domain.UnitWork;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var stringConnection = builder.Configuration.GetConnectionString("DefaulcConnection");

builder.Services.AddDbContext<DataContexto>(options =>
{
    options.UseSqlServer(stringConnection);
});

//INTEFACE / REPOSITORY
builder.Services.AddScoped<IProdutosServices, ProdutosRepository>();
builder.Services.AddScoped<IProdutoItensService, ProdutoItensRepository>();
builder.Services.AddScoped<ISubItensServices, SubItensRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

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
