using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using Zakharov.Utilities;

namespace Zakharov.Origin.Model {
    public class CContext:  DbContext {
        public DbSet<CPerson> Persons { get; set; }       
        protected override void OnModelCreating(DbModelBuilder x_mbModelBuilder) {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CContext>());
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<CContext, CConfiguration>());
            x_mbModelBuilder.Entity<CPerson>().Property(p => p.BirthDate.DateTime).HasColumnName("BirthDate");
            base.OnModelCreating(x_mbModelBuilder);
        }
    }
    public class CConfiguration : DbMigrationsConfiguration<CContext> {
        public CConfiguration() {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
