using ParserGamer.Data.EntityConfig;
using ParserGamer.Domain.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace ParserGamer.Data.Context
{
    public class ContextDataBase : DbContext
    {
        public DbSet<Player> Player { get; set; }
        public DbSet<Game> Game { get; set; }
        public DbSet<Information> Information { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                 .Where(x => x.Name == x.ReflectedType.Name + "id")
                .Configure(x => x.IsKey());

            modelBuilder.Properties<string>()
               .Configure(x => x.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
               .Configure(x => x.HasMaxLength(100));

            modelBuilder.Configurations.Add(new GameConfiguration());
            modelBuilder.Configurations.Add(new InformationConfiguration());
            modelBuilder.Configurations.Add(new PlayerConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DateRegister") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DateRegister").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DateRegister").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
