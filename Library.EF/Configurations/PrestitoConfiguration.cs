using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.EF.Configurations
{
    public class PrestitoConfiguration : IEntityTypeConfiguration<Prestito>
    {
        public void Configure(EntityTypeBuilder<Prestito> builder)
        {
            builder
                .HasKey(l => l.Id);

            builder
                .Property(l => l.DataPrestito)
                .IsRequired();

            builder
                .Property(l => l.DataReso)
                .IsRequired(false);

            builder
                .HasOne(l => l.Book)
                .WithMany(b => b.Prestiti)
                .HasForeignKey(l => l.IdBook);
        }
    }
}