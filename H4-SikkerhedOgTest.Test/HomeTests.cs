using Bunit.TestDoubles;

using H4_IdentityPlatform.Components.Account.Pages;
using H4_IdentityPlatform.Components.Pages;
using H4_IdentityPlatform.Data;

using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using SQLitePCL;

using System.Diagnostics.Metrics;
using System.Security.Principal;

namespace H4_SikkerhedOgTest.Test {
    public class HomeTests : TestContext {
        private const string TestUserEmail = "test@user.com";
        private const string TestUserPassword = "xzr3,HZFuaE`*y~q";
        private TestAuthorizationContext AuthContext;
        public HomeTests() {
            Services.AddCascadingAuthenticationState();
            Services.AddAuthentication(options => {
                options.DefaultScheme = IdentityConstants.ApplicationScheme;
                options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
            }).AddIdentityCookies();

            Services.AddDbContext<AuthDbContext>(options => options.UseInMemoryDatabase("AuthDB"));
            Services.AddDatabaseDeveloperPageExceptionFilter();

            Services.AddIdentityCore<AuthUser>(options => options.SignIn.RequireConfirmedAccount = true)
                     .AddRoles<IdentityRole>()
                     .AddRoleManager<RoleManager<IdentityRole>>()
                     .AddEntityFrameworkStores<AuthDbContext>()
                     .AddDefaultTokenProviders()
                     .AddSignInManager();

            Services.AddScoped<RoleManager<IdentityRole>>();
            Services.AddScoped<UserManager<AuthUser>>();
            AuthContext = this.AddTestAuthorization();
        }



        [Fact]
        public void ShouldDisplayNotLoggedInMessageWhenAuthorizing() {
            // Arrange
            AuthContext.SetAuthorized(TestUserEmail, AuthorizationState.Authorizing);
            var cut = RenderComponent<H4_IdentityPlatform.Components.Pages.Home>();
            var elem = cut.Find("#login-state");

            // Act


            // Assert
            bool elemHasDenyClass = elem.ClassList.Contains("deny");
            string elemText = elem.TextContent;

            Assert.True(elemHasDenyClass);
            Assert.Equal(Home.notLoggedInText, elemText);
        }

        [Fact]
        public void ShouldDisplayNotLoggedInMessageWhenUnauthorized() {
            // Arrange
            AuthContext.SetAuthorized(TestUserEmail, AuthorizationState.Unauthorized);
            var cut = RenderComponent<H4_IdentityPlatform.Components.Pages.Home>();
            var elem = cut.Find("#login-state");

            // Act


            // Assert
            bool elemHasDenyClass = elem.ClassList.Contains("deny");
            string elemText = elem.TextContent;

            Assert.True(elemHasDenyClass);
            Assert.Equal(Home.notLoggedInText, elemText);
        }

        [Fact]
        public void ShouldDisplayLoggedInMessageWhenAuthorized() {
            // Arrange
            AuthContext.SetAuthorized(TestUserEmail, AuthorizationState.Authorized);
            var cut = RenderComponent<H4_IdentityPlatform.Components.Pages.Home>();
            var elem = cut.Find("#login-state");

            // Act


            // Assert
            bool elemHasDenyClass = elem.ClassList.Contains("accept");
            string elemText = elem.TextContent;

            Assert.True(elemHasDenyClass);
            Assert.Equal(H4_IdentityPlatform.Components.Pages.Home.loggedInText, elemText);
        }
    }
}