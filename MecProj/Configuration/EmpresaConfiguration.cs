using MecProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MecProj.Configuration
{
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa");
            builder.Property(x => x.Razão_Social).IsRequired();
            builder.HasIndex(x => x.Cnpj).IsUnique();
            builder.Property(x => x.Telefone_Celular).IsRequired();
            builder.Property(x => x.Estado).IsRequired();
            builder.Property(x => x.Bairro).IsRequired();
            builder.Property(x => x.Rua).IsRequired();
            builder.Property(x => x.Numero).IsRequired();
        }
    }
}
