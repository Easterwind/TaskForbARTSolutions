using Occurrence.DAL.Models;
using Occurrence.DAL.Repositories.Interfaces;

namespace Occurrence.DAL.Repositories
{
    public class IncidentRepository : IIncidentRepository
    {
        private OccurrenceDbContex context;
        public IncidentRepository(OccurrenceDbContex context)
        {
            this.context = context;
        }
        public async Task InsertAsync(Incident incident)
        {
            context.Incidents.Add(incident);
            await context.SaveChangesAsync();
        }
    }
}
