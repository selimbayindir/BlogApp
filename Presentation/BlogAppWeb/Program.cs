using DataAccess.ConfigurationsJson;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//My
///var asembly =Assembly.GetExecutingAssembly().FullName;

// Add services to the container.
builder.Services.AddRazorPages();

//
builder.Services.AddPersistenceServices();
//
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
