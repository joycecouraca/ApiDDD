using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping {
    public class ClienteMap : IEntityTypeConfiguration<Cliente> {
        public void Configure (EntityTypeBuilder<Cliente> builder) {
            builder.ToTable ("Cliente");
            builder.HasKey (c => c.Id);
            builder.Property (c => c.Nome).IsRequired ().HasMaxLength (60);
            builder.Property (c => c.Endereco).IsRequired ().HasMaxLength (60);
            builder.Property (c => c.Numero).IsRequired ().HasMaxLength (10);
            builder.Property (c => c.Bairro).IsRequired ().HasMaxLength (60);
            builder.Property (c => c.Cep).IsRequired ().HasMaxLength (10);
            builder.Property (c => c.Sexo).IsRequired ().HasMaxLength (10);
            builder.Property (c => c.Cidade).IsRequired ().HasMaxLength (50);
            builder.Property (c => c.Estado).IsRequired ().HasMaxLength (50);
            builder.Property (c => c.DataNascimento).IsRequired ();

        }
    }
}
