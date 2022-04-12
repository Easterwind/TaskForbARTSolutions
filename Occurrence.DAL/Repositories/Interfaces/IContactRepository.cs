using Occurrence.DAL.Models;

namespace Occurrence.DAL.Repositories.Interfaces
{
    public interface IContactRepository
    {
        Task InsertAsync(Contact contact);
        Task UpdateAsync(Contact contact);
        Task<Contact> GetByEmailAsync(string email);
    }
}
