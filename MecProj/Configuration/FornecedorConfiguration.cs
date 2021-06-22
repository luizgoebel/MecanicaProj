using MecProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MecProj.Configuration
{
    public class FornecedorConfiguration : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedor");
            builder.Property(x => x.Nome).HasMaxLength(50).IsRequired();
            builder.HasIndex(x => x.CNPJ).IsUnique();
            builder.Property(x => x.CNPJ).HasMaxLength(19).IsRequired();
            builder.Property(x => x.Cidade).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Bairro).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Rua).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Numero).HasMaxLength(5).IsRequired();
            builder.Property(x => x.Observacao).HasMaxLength(200);
            builder.Property(x => x.Data_Cadastro).IsRequired();


        }
    }
}
