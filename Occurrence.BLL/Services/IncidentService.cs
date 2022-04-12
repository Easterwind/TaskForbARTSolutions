using Occurrence.BLL.Services.Interfaces;
using Occurrence.DAL.Models;
using Occurrence.DAL.Repositories.Interfaces;

namespace Occurrence.BLL.Services
{
    public class IncidentService: IIncidentService
    {
        private readonly IIncidentRepository _incidentRepository;

        public IncidentService(IIncidentRepository incidentRepository)
        {
            _incidentRepository = incidentRepository;
        }

        public async Task InsertAsync(Incident incident)
        {
            await _incidentRepository.InsertAsync(incident);
        }
    }
}
