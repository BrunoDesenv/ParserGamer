using ParserGamer.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ParserGamer.Data.EntityConfig
{
    public class InformationConfiguration : EntityTypeConfiguration<Information>
    {
        public InformationConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(100);

            Property(x => x.DateRegister)
                .IsRequired();

            HasRequired(x => x.Player1)
                 .WithMany()
                 .HasForeignKey(x => x.IdPlayer1);

            HasRequired(x => x.Player2)
           .WithMany()
           .HasForeignKey(x => x.IdPlayer2);
        }
    }
}
