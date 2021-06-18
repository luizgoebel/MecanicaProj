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
            builder.ToTable("Servicos");
            builder.Property(x => x.Service).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Descricao).HasMaxLength(30);
            builder.Property(x => x.Entrada).IsRequired();
            builder.Property(x => x.Situacao).IsRequired();
        }
    }
}
