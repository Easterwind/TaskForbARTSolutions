using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Occurrence.BLL.Services.Interfaces;
using Occurrence.DTO;

namespace Occurrence.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncidentController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IAccountService _accountService;
        private readonly IIncidentService _incidentService;

        public IncidentController(IContactService contactService, IAccountService accountService, IIncidentService incidentService)
        {
            _contactService = contactService;
            _accountService = accountService;
            _incidentService = incidentService;
        }

        [HttpPost]
        public async Task<IActionResult> InsertAsync([FromBody] CreateDto dto)
        {
            if (ModelState.IsValid)
            {
                var account = await _accountService.GetByNameAsync(dto.AccountName);
                if (account == null)
                    return NotFound();
                var contact = await _contactService.GetByEmailAsync(dto.ContactEmail);
                if (contact != null)
                {
                    if (!account.Contacts.Contains(contact))
                    {
                        account.Contacts.Add(contact);
                        await _accountService.UpdateAsync(account);
                    }
                }
                else
                {
                    var newContact = new DAL.Models.Contact
                    {
                        FirstName = dto.ContactFirstName,
                        LastName = dto.ContactLastName,
                        Email = dto.ContactEmail,
                        Account = account
                    };
                    await _contactService.InsertAsync(newContact);

                    var newIncident = new DAL.Models.Incident
                    {
                        Description = dto.IncidentDescription,
                        Accounts = new List<DAL.Models.Account> { account }
                    };
                    await _incidentService.InsertAsync(newIncident);
                }
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
