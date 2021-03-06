﻿using ParserGamer.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ParserGamer.Data.EntityConfig
{
    public class PlayerConfiguration : EntityTypeConfiguration<Player>
    {
        public PlayerConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(x => x.Kills)
                .IsRequired();

            Property(x => x.DateRegister)
                .IsRequired();

            HasRequired(x => x.Game)
                .WithMany(x => x.Players)
                .HasForeignKey(x => x.IdGame);
        }
    }
}
