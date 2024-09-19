using H4_IdentityPlatform.Components.Account.Pages;
using H4_IdentityPlatform.Components.Pages;

using System.Diagnostics.Metrics;

namespace H4_SikkerhedOgTest.Test {
    public class AuthTests {
        private const string TestUserEmail = "test@user.com";
        private const string TestUserPassword = "xzr3,HZFuaE`*y~q";


        private readonly TestHelper _helper;
        public AuthTests() {
            _helper = new TestHelper();
        }

        [Fact]
        public void UserCanRegister() {
            // Arrange
            

            using var ctx = new TestContext();
            var cut = ctx.RenderComponent<Register>();
            var emailElem = cut.Find("body > div.page > main > article > div > div.col-md-4 > form > div:nth-child(5) > input");
            var passwordElem = cut.Find("body > div.page > main > article > div > div.col-md-4 > form > div:nth-child(6) > input");
            var confirmElem = cut.Find("body > div.page > main > article > div > div.col-md-4 > form > div:nth-child(7) > input");

            // Act
            emailElem.SetAttribute("value", TestUserEmail);
            passwordElem.SetAttribute("value", TestUserPassword);
            confirmElem.SetAttribute("value", TestUserPassword);

            // Assert

            Assert.True(elemHasDenyClass);
            Assert.Equal(Home.notLoggedInText, elemText);
        }

        [Fact]
        public void HomeShouldDisplayNotLoggedInMessage() {
            // Arrange
            using var ctx = new TestContext();
            var cut = ctx.RenderComponent<Home>();
            var elem = cut.Find("#login-state");

            // Act


            // Assert
            bool elemHasDenyClass = elem.ClassList.Contains("deny");
            string elemText = elem.TextContent;

            Assert.True(elemHasDenyClass);
            Assert.Equal(Home.notLoggedInText, elemText);
        }

        [Fact]
        public void HomeShouldDisplayLoggedInMessage() {
            // Arrange
            using var ctx = new TestContext();
            var cut = ctx.RenderComponent<Home>();
            var elem = cut.Find("#login-state");

            // Act


            // Assert
            bool elemHasDenyClass = elem.ClassList.Contains("deny");
            string elemText = elem.TextContent;

            Assert.True(elemHasDenyClass);
            Assert.Equal(Home.notLoggedInText, elemText);
        }
    }
}