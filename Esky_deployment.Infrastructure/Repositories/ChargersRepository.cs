using Esky_deployment.Application.Common;
using Esky_deployment.Domain.Entities;
using Esky_deployment.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Esky_deployment.Infrastructure.Repositories;


public class ChargersRepository : IChargersRepository
{
    private readonly AppDbContext _context;

    public ChargersRepository(AppDbContext context)
    {
        this._context = context;
    }

    public async Task<Chargers> CreateAsync(Chargers charger)
    {
        await _context.Chargers.AddAsync(charger);
        await _context.SaveChangesAsync();
        return charger;
    }

    public async Task DeleteAsync(Chargers charger)
    {
        _context.Chargers.Remove(charger);
        await _context.SaveChangesAsync();
    }

    public async Task<PaginationResult<Chargers>> GetAllAsync(int page, int pageSize)
    {
        var query = _context.Chargers.AsNoTracking();

        var total = await query.CountAsync();

        var items = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

        return new PaginationResult<Chargers>
        {
            Page = page,
            PageSize = pageSize,
            Items = items,
            TotalItems = total
        };
    }

    public async Task<Chargers?> GetByIdAsync(int id)
    {
        return await _context.Chargers.FirstOrDefaultAsync(x=> x.Id == id);
    }

    public async Task UpdateAsync(Chargers charger)
    {
        _context.Chargers.Update(charger);
        await _context.SaveChangesAsync();
    }
}