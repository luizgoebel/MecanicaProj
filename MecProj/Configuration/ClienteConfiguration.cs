using MecProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MecProj.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.Property(x => x.Nome).HasMaxLength(50).IsRequired();
            builder.HasIndex(x => x.Cpf_Cnpj).IsUnique();
            builder.Property(x => x.Cpf_Cnpj).HasMaxLength(19).IsRequired();
            builder.Property(x => x.Estado).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Cidade).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Bairro).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Rua).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Numero).HasMaxLength(5).IsRequired();
            builder.Property(x => x.Complemento).HasMaxLength(50);
            builder.Property(x => x.TelefoneRecado).HasMaxLength(17);
            builder.Property(x => x.TelefoneCelular).HasMaxLength(17).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(30);
            //builder.Property(x => x.Placa).HasMaxLength(10).IsRequired();
            //builder.Property(x => x.Marca).HasMaxLength(10).IsRequired();
            //builder.Property(x => x.Modelo).HasMaxLength(10).IsRequired();
            //builder.Property(x => x.Ano).IsRequired();
            //builder.Property(x => x.Observacao).HasMaxLength(200);
        }
    }
}
