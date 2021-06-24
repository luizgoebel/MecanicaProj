using MecProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MecProj.Configuration
{
    public class OrdemConfiguration : IEntityTypeConfiguration<OrdemServico>
    {
        public void Configure(EntityTypeBuilder<OrdemServico> builder)
        {
            builder.ToTable("Servico");
            builder.Property(x => x.Cliente).HasMaxLength(200).IsRequired();
            builder.Property(x => x.CPF_CNPJ).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Marca_Veiculo).IsRequired();
            builder.Property(x => x.Modelo_Veiculo).IsRequired();
            builder.Property(x => x.Service).IsRequired();
            builder.Property(x => x.Entrada).IsRequired();
            builder.Property(x => x.Situacao).IsRequired();
        }
    }
}
