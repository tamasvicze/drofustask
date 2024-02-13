using System.Collections.Concurrent;

namespace drofustask2.Server.Services
{
    public class ContactService : IContactService
    {
        private readonly ConcurrentDictionary<int, Contact> _contacts = new();

        public ContactService()
        {
            for (int i = 1; i <= 50; i++)
            {
                _contacts.TryAdd(i, new Contact
                {
                    Id = i,
                    Name = $"Name {i}",
                    JobTitle = $"JobTitle {i}",
                    Address = $"Address {i}",
                    Phone = $"Phone {i}",
                    Birthday = DateTime.Now.AddYears(-i),
                    Workplace = $"Workplace {i}"
                });
            }
        }

        public IEnumerable<Contact> GetAllContacts() => _contacts.Values;

        public Contact GetContactById(int id) => _contacts.TryGetValue(id, out var contact) ? contact : null;
    }
}
