using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using JustBlog.Domain.Enitities;
using JustBlog.Infrastructure.Context;
using JustBlog.Infrastructure.Repositories.Implementations;
using JustBlog.Infrastructure.Repositories.Interfaces;
using JustBlog.Infrastructure.Repositories;
using JustBlog.Infrastructure.UnitOfWork;
using JustBlog.Application.Mappings;

namespace JustBlog.WebApp;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        //var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        //builder.Services.AddDbContext<ApplicationDbContext>(options =>
        //    options.UseSqlServer(connectionString));
        //builder.Services.AddDatabaseDeveloperPageExceptionFilter();

        //builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
        //    .AddEntityFrameworkStores<ApplicationDbContext>();

        builder.Services.AddDbContext<JustBlogDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        //// ??ng ký Identity
        builder.Services.AddIdentity<User, Role>()
            .AddEntityFrameworkStores<JustBlogDbContext>()
            .AddDefaultTokenProviders();

        // ??ng ký Repository và Unit of Work
        builder.Services.AddScoped<IPostRepository, PostRepository>();
        builder.Services.AddScoped<ICommentRepository, CommentRepository>();
        builder.Services.AddScoped<IUserRepository, UserRepository>();
        builder.Services.AddScoped<IRoleRepository, RoleRepository>();
        builder.Services.AddScoped<IGenericRepository<Category, Guid>, GenericRepository<Category, Guid>>();
        builder.Services.AddScoped<IGenericRepository<Tag, Guid>, GenericRepository<Tag, Guid>>();
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

        // Đăng ký AutoMapper với profile MappingProfile
        builder.Services.AddAutoMapper(typeof(MappingProfile));
        
        builder.Services.AddControllersWithViews();
        builder.Services.AddRazorPages();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseMigrationsEndPoint();
        }
        else
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
        app.MapRazorPages();

        app.Run();
    }
}
