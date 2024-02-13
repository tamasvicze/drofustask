using drofustask2.Server.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace drofustask2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        [HttpGet("listview")]
        public IEnumerable<Contact> GetAllContacts()
        {
            return _contactService.GetAllContacts();
        }

        [HttpGet("/detailview/{id}")]
        public ActionResult<Contact> GetContactById(int id)
        {
            var contact = _contactService.GetContactById(id);
            return contact != null ? Ok(contact) : NotFound();
        }
    }
}
