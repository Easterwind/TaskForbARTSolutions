using Occurrence.DAL.Models;

namespace Occurrence.DAL.Repositories.Interfaces
{
    public interface IAccountRepository
    {
        Task InsertAsync(Account account);
        Task UpdateAsync(Account account);
        Task<Account> GetByNameAsync(string Name);
    }
}
