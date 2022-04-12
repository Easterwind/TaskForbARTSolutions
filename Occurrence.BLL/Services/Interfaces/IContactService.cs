using Occurrence.DAL.Models;

namespace Occurrence.BLL.Services.Interfaces
{
    public interface IContactService
    {
        Task InsertAsync(Contact contact);
        Task UpdateAsync(Contact contact);
        Task<Contact> GetByEmailAsync(string email);
    }
}
