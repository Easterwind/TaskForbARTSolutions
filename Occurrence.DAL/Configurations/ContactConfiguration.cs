using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Occurrence.DAL.Models;

namespace Occurrence.DAL.Configurations
{
    public static class  ContactConfiguration
    {
        public static void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts").HasKey(c => c.Email);
            builder.HasOne(c => c.Account)
                   .WithMany(a => a.Contacts);
        }
    }
}
