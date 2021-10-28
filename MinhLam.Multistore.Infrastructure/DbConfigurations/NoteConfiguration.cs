using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinhLam.MultiStore.Domain.Entities;

namespace MinhLam.Multistore.Infrastructure.DbConfigurations
{
    public class NoteConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.ToTable("Notes")
               .HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(200).IsUnicode().IsRequired();
            builder.Property(x => x.Detail).HasMaxLength(600).IsUnicode().IsRequired();
            builder.Property(x => x.NoteDate).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
        }
    }
}
