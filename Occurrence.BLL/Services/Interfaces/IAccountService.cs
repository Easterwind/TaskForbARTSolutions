using Occurrence.DAL.Models;

namespace Occurrence.BLL.Services.Interfaces
{
    public interface IAccountService
    {
        Task InsertAsync(Account account);
        Task UpdateAsync(Account account);
        Task<Account> GetByNameAsync(string name);
    }
}
