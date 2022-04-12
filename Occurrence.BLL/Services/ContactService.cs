using Occurrence.BLL.Services.Interfaces;
using Occurrence.DAL.Models;
using Occurrence.DAL.Repositories.Interfaces;

namespace Occurrence.BLL.Services
{
    public class ContactService: IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<Contact> GetByEmailAsync(string email)
        {
            return await _contactRepository.GetByEmailAsync(email);
        }

        public async Task InsertAsync(Contact contact)
        {
           await _contactRepository.InsertAsync(contact);
        }

        public async Task UpdateAsync(Contact contact)
        {
           await _contactRepository.UpdateAsync(contact);
        }
    }
}
