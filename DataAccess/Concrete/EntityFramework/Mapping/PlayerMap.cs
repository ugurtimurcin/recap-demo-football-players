using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
    public class PlayerMap : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.ShirtNo).IsRequired();

            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(75);

            builder.Property(x => x.Appearance).IsRequired();

            builder.Property(x => x.Goal).IsRequired();

            builder.Property(x => x.PositionId).IsRequired();

            builder.HasOne(x => x.Club).WithMany(x => x.Players).HasForeignKey(x => x.ClubId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
