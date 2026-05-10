using Microsoft.EntityFrameworkCore;
using csci340lab8.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddDbContext<GameContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("GameContext")
    ?? throw new InvalidOperationException("Connection string not found.")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
