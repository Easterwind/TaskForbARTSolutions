using Microsoft.EntityFrameworkCore;
using Occurrence.DAL.Models;
using Occurrence.DAL.Repositories.Interfaces;

namespace Occurrence.DAL.Repositories
{
    public class AccountRepository: IAccountRepository
    {
        private OccurrenceDbContex context;
        public AccountRepository(OccurrenceDbContex context)
        {
            this.context = context;
        }

        public async Task InsertAsync(Account account)
        {
            context.Accounts.Add(account);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Account account)
        {
            context.Entry(account).State = EntityState.Modified;
            context.Entry(account).Property(u => u.Name).IsModified = false;
            context.Entry(account).Property(u => u.Incident).IsModified = false;
            await context.SaveChangesAsync();
        }
        public async Task<Account> GetByNameAsync(string name)
        {
            return await context.Accounts
              .Where(a => a.Name == name)
              .FirstOrDefaultAsync();
        }
    }
}
