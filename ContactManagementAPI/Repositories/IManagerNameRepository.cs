using ContactManagementAPI.Models;

namespace ContactManagementAPI.Repositories;

public interface IManagerNameRepository
{
    Task<IEnumerable<ManagerName>> GetAllManagerName();
    Task<ManagerName?> GetManagerNameById(int id);
}