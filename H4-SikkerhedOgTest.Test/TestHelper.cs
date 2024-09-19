using H4_IdentityPlatform.Data;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_SikkerhedOgTest.Test {
    public class TestHelper: IDisposable {
        private readonly AuthDbContext _AuthDbContext;
        public TestHelper() {
            var builder = new DbContextOptionsBuilder<AuthDbContext>();
            builder.UseInMemoryDatabase(databaseName: "AuthDbInMemory");

            var dbContextOptions = builder.Options;
            _AuthDbContext = new AuthDbContext(dbContextOptions);

            // Delete existing db before creating a new one
            _AuthDbContext.Database.EnsureDeleted();
            _AuthDbContext.Database.EnsureCreated();
        }

        public void Dispose() {
            _AuthDbContext.Database.EnsureDeleted();
        }
    }
}
