using DNTFrameworkCore.TestTenancy.Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DNTFrameworkCore.TestTenancy.Infrastructure.Mappings.Identity
{
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.Property(a => a.Name).HasMaxLength(Permission.MaxNameLength).IsRequired();
            builder.Property<string>("Discriminator").HasMaxLength(50);

            builder.HasIndex("Discriminator").HasName("IX_Permission_Discriminator");

            builder.ToTable(nameof(Permission));
        }
    }
}