using FeedLawyer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedLawyer.Infrastructure.Data.Mappings
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            // Outras configurações de propriedade
            builder.Property(u => u.UserName).IsRequired();
            builder.Property(u => u.Email).IsRequired();

            // Configuração do relacionamento N:N
            builder.HasMany(u => u.Roles)
                   .WithMany(r => r.Users)
                   .UsingEntity(j =>
                   {
                       j.ToTable("UsersRoles"); // Nome da tabela de junção
                   });
        }
    }
}
