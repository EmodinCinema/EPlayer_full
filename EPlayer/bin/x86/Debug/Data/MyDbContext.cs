using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.CodeFirst;

namespace EPlayer.bin.x86.Debug.Data
{ 
public class MyDbContext : DbContext
    {
        public MyDbContext() 
            :base() { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<MyDbContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

            /*var = = modelBuilder.Build(Database.Connection);
            ISqlGenerator sqlGenerator = new SqliteSqlGenerator();*/
        }

        /*public DbSet<Tables.Person> Persons { get; set; }
        public DbSet<Tables.Role> Roles { get; set; }
        public DbSet<Tables.Order> Orders { get; set; }*/
    }
}
