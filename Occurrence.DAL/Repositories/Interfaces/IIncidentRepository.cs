using Occurrence.DAL.Models;

namespace Occurrence.DAL.Repositories.Interfaces
{
    public interface IIncidentRepository
    {
        Task InsertAsync(Incident incident);
    }
}
