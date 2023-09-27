using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.Configuration;

public class PaisConfiguration : IEntityTypeConfiguration<Pais>
{
    public void Configure(EntityTypeBuilder<Pais> builder)
    {
        //Aqui puedes configurar las propiedades se la entidad País
        //utilizando el objeto builder
        builder.ToTable("pais");

        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);
        
        builder.Property(p => p.Nombre).IsRequired().HasMaxLength(50);
    }
}
