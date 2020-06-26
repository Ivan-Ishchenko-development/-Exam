using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Data.Entity;

namespace ExLayer.DAL.EF
{
    class ChaildContext : DbContext 
    {
        public DbSet<Chaild> Chailds { get; set; }
        public DbSet<Parents> Parents { get; set; }
        public DbSet<Group> Groups { get; set; }

        static ChaildContext()
        {
            Database.SetInitializer<ChaildContext>(new StoreDbInitializer());
        }
        public ChaildContext(string connectionString)
            : base(connectionString)
        {
        }
    }

    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<ChaildContext>
    {
        protected override void Seed(ChaildContext db)
        {
            db.Chailds.Add(new Chaild { FullName = "Петренко Петрович Петр", Age = 5});
            db.Chailds.Add(new Chaild { FullName = "Петренко Петрович Петр", Age = 5});
            db.SaveChanges();
        }
    }
}
