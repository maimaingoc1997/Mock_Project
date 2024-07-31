using ContactManagementAPI.Data;
using ContactManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManagementAPI.Repositories;

public class ManagerNameRepository : IManagerNameRepository
{
    private readonly ContactDbContext _context;

    public ManagerNameRepository(ContactDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ManagerName>> GetAllManagerName()
    {
        return await _context.ManagerNames.ToListAsync();
    }

    public async Task<ManagerName?> GetManagerNameById(int id)
    {
        return await _context.ManagerNames.FindAsync(id);
    }
}