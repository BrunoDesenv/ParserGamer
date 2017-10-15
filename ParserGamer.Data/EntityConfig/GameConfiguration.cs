using ParserGamer.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ParserGamer.Data.EntityConfig
{
    public class GameConfiguration : EntityTypeConfiguration<Game>
    {
        public GameConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.TimeStart)
                .IsRequired();

            Property(x => x.TimeEnd)
                .IsRequired();

            Property(x => x.DateRegister)
                .IsRequired();

            Property(x => x.TotalKills);

            HasOptional(x => x.Information)
                .WithMany()
                .HasForeignKey(x => x.IdInformation);

        }
    }
}
