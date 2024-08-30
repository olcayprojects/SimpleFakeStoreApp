using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SimpleFakeStoreApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddHttpClient<ProductService>(client =>
{
    client.BaseAddress = new Uri("https://fakestoreapi.com/"); // Temel API adresi
});
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
