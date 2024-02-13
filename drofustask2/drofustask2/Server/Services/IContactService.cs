
namespace drofustask2.Server.Services
{
    public interface IContactService
    {
        IEnumerable<Contact> GetAllContacts();
        Contact GetContactById(int id);
    }
}
