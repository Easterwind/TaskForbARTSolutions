using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Occurrence.DAL.Models;

namespace Occurrence.DAL.Configurations
{
    public static class AccountConfiguration
    {
        public static void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts").HasKey(a => a.Name);
            builder.HasOne(a => a.Incident)
                   .WithMany(i => i.Accounts);
        }
    }
}
