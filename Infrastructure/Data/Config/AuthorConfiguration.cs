using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Config
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasOne(c => c.Book).WithOne().HasForeignKey<Book>(p => p.AutorId);
            builder.Property(p => p.Nombres).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Apellidos).IsRequired().HasMaxLength(100);
            builder.Property(p => p.FechaDeNacimiento).IsRequired().HasAnnotation("Uno",null);
        }
    }
}
