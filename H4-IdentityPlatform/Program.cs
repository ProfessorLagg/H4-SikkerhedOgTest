using H4_IdentityPlatform.Components;
using H4_IdentityPlatform.Components.Account;
using H4_IdentityPlatform.Data;

using Microsoft.AspNetCore.Authentication.Certificate;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

using SQLitePCL;

namespace H4_IdentityPlatform {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                    .AddInteractiveServerComponents();

            builder.Services.AddCascadingAuthenticationState();
            builder.Services.AddScoped<IdentityUserAccessor>();
            builder.Services.AddScoped<IdentityRedirectManager>();
            builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

            builder.Services.AddAuthentication(options => {
                options.DefaultScheme = IdentityConstants.ApplicationScheme;
                options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
            }).AddIdentityCookies();

            var connectionStringAuthBase = builder
                .Configuration
                .GetConnectionString("SQLiteAuthDB");
            var connectionStringAuth = new SqliteConnectionStringBuilder(connectionStringAuthBase).ToString();

            SQLitePCL.raw.SetProvider(new SQLite3Provider_e_sqlite3());

            builder.Services.AddDbContext<AuthDbContext>(options => options.UseSqlite(connectionStringAuth));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddIdentityCore<AuthUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddRoles<IdentityRole>()
                    .AddRoleManager<RoleManager<IdentityRole>>()
                    .AddEntityFrameworkStores<AuthDbContext>()
                    .AddDefaultTokenProviders()
                    .AddSignInManager();

            builder.Services.AddAuthorization(options => {
                options.AddPolicy("AdminPolicy", policy => {
                    policy.RequireRole("AdminRole");
                });
            });

            builder.Services.AddSingleton<IEmailSender<AuthUser>, IdentityNoOpEmailSender>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment()) {
                app.UseMigrationsEndPoint();
            }
            else {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                    .AddInteractiveServerRenderMode();

            // Add additional endpoints required by the Identity /Account Razor components.
            app.MapAdditionalIdentityEndpoints();

            app.Run();
        }
    }
}
