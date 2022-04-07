using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasOne(p => p.Categoria).WithMany().HasForeignKey(p => p.CategoriaId).IsRequired();
            builder.HasOne(p => p.Editorial).WithMany().HasForeignKey(p => p.EditorialId).IsRequired();
            builder.Property(p => p.Titulo).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Autor).IsRequired().HasMaxLength(100);
            builder.Property(p => p.FechaDePublicacion).IsRequired();
            builder.Property(p => p.NumeroDePaginas).IsRequired();
            builder.Property(p => p.Precio).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(p => p.Disponibilidad).IsRequired();

        }
    }
}
