using Microsoft.EntityFrameworkCore;
using NetCoreCookie_0.Models.ContextClasses;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<NorthwindContext>(x => x.UseSqlServer());

builder.Services.AddDistributedMemoryCache(); //Eger Session kompleks yapılarla calısmak icin Extension metodu eklenme durumuna maruz kalmıssa bu kod projenizin saglıklı calısması icin gereklidir...

builder.Services.AddSession( x =>
{
    x.IdleTimeout = TimeSpan.FromMinutes(1); //Projeyi kişinin bos durma süresi eger 1 dakikalık bir bos durma süresi olursa Session bosa cıksın...
    x.Cookie.HttpOnly = true; //document.cookie'den ilgili bilginin gözlemlenmesi
    x.Cookie.IsEssential = true;
});

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
