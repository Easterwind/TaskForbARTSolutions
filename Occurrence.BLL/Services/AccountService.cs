using Occurrence.BLL.Services.Interfaces;
using Occurrence.DAL.Models;
using Occurrence.DAL.Repositories.Interfaces;

namespace Occurrence.BLL.Services
{
    public class AccountService: IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<Account> GetByNameAsync(string name)
        {
            return await _accountRepository.GetByNameAsync(name);
        }

        public async Task InsertAsync(Account account)
        {
            await _accountRepository.InsertAsync(account);
        }

        public async Task UpdateAsync(Account account)
        {
            await _accountRepository.UpdateAsync(account);
        }
    }
}
