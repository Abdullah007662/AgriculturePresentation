using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Conteiner;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFrameWork;
using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AgricultureContext>();
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AgricultureContext>();
builder.Services.ConteinerDependencies();

builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();//Yetkilendirme Politikas�
    config.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.AddMvc();
builder.Services.AddAuthentication(
    CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(x =>
    {
        x.LoginPath = "/Login/Index/";//E�er Ki�i Sisteme Authentication de�ilse buraya y�nlendirilsin.
    });

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
app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
