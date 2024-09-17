using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace H4_IdentityPlatform.Data {
    public class AuthDbContext(DbContextOptions<AuthDbContext> options) : IdentityDbContext<AuthUser>(options) {
    }
}
