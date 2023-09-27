using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.Configuration;

public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {
        //Aqui puedes configurar las propiedades se la entidad País
        //utilizando el objeto builder
        builder.ToTable("departamento");

        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.Nombre).IsRequired().HasMaxLength(50);
        
        builder.HasOne(e => e.Paises).WithMany(e => e.Departamentos).HasForeignKey(e => e.IdPaisFk);

    }
}
