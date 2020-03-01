using System;
using lifebet.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lifebet.dataaccess.EntityMapping
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("events");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasColumnName("event_name");
        }
    }
}
