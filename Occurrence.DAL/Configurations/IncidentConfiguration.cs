using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Occurrence.DAL.Models;

namespace Occurrence.DAL.Configurations
{
    public static class IncidentConfiguration
    {
        public static void Configure(EntityTypeBuilder<Incident> builder)
        {
            builder.ToTable("Incidents").HasKey(i => i.Name);
            builder.Property(i => i.Name).ValueGeneratedOnAdd();
        }
    }
}
