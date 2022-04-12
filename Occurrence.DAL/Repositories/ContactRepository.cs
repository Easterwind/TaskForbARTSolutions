using Microsoft.EntityFrameworkCore;
using Occurrence.DAL.Models;
using Occurrence.DAL.Repositories.Interfaces;

namespace Occurrence.DAL.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private OccurrenceDbContex context;
        public ContactRepository(OccurrenceDbContex context)
        {
            this.context = context;
        }

        public async Task<Contact> GetByEmailAsync(string email)
        {
            return await context.Contacts
              .Where(c => c.Email == email)
              .FirstOrDefaultAsync();
        }

        public async Task InsertAsync(Contact contact)
        {
            context.Contacts.Add(contact);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Contact contact)
        {
            context.Entry(contact).State = EntityState.Modified;
            context.Entry(contact).Property(c => c.Email).IsModified = false;
            context.Entry(contact).Property(c => c.Account).IsModified = false;
            await context.SaveChangesAsync();
        }
    }
}
