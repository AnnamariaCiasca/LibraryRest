using Library.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.EF.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder
                .HasKey(b => b.Id);

            builder
                .Property(b => b.ISBN)
                .IsRequired();

            builder
                .Property(b => b.Title)
                .IsRequired();

            builder
                .Property(b => b.Author);

            builder
        .HasMany(b => b.Prestiti)
        .WithOne(l => l.Book);
        }
    }
}