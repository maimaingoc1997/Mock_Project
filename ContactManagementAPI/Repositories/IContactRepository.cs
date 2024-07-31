using ContactManagementAPI.Models;

namespace ContactManagementAPI.Repositories;

public interface IContactRepository
{
    Task<IEnumerable<Contact>> GetAllContacts();
    Task<Contact?> GetContactById(int id);
    Task AddContact(Contact contact);
    Task UpdateContact(Models.Contact contact);

}