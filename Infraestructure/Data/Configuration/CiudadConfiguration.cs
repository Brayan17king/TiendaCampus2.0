using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.Configuration;

public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
{
    public void Configure(EntityTypeBuilder<Ciudad> builder)
    {
        //Aqui puedes configurar las propiedades se la entidad País
        //utilizando el objeto builder
        builder.ToTable("ciudad");

        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.Nombre).IsRequired().HasMaxLength(50);

        builder.HasOne(e => e.Departamentos).WithMany(e => e.Ciudades).HasForeignKey(e => e.IdDepartamentoFk);
        
    }
}
