using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStoreAPIv3NET7.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStoreAPIv3NET7.Data.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.Property(game => game.Price)
                    .HasPrecision(5, 2);
        }
    }
}