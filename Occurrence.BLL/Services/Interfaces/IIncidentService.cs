using Occurrence.DAL.Models;

namespace Occurrence.BLL.Services.Interfaces
{
    public interface IIncidentService
    {
        Task InsertAsync(Incident incident);
    }
}
