using Esky_deployment.Application.Common;
using Esky_deployment.Domain.Entities;
using Esky_deployment.Esky_deployment.Application.Interfaces;
using Esky_deployment.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Esky_deployment.Esky_deployment.Infrastructure.Repositories;

public class SimRepository : ISimRepository
{
    private readonly AppDbContext _context;
    public SimRepository(AppDbContext context)
    {
        this._context = context;
    }
    public async Task<Sims> CreateAsync(Sims input)
    {
        await _context.Sims.AddAsync(input);
        await _context.SaveChangesAsync();
        return input;
    }

    public async Task DeleteAsync(Sims input)
    {
        _context.Sims.Remove(input);
        await _context.SaveChangesAsync();
    }

    public async Task<PaginationResult<Sims>> GetAllAsync(int page, int pageSize)
    {
        var query = _context.Sims.AsNoTracking();

        var total = await query.CountAsync();

        var items = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

        return new PaginationResult<Sims>
        {
            Page = page,
            PageSize = pageSize,
            TotalItems = total,
            Items = items
        };
    }

    public async Task<Sims?> GetByIdAsync(int id)
    {
        return await _context.Sims.FirstOrDefaultAsync(x=>x.Id == id);
    }

    public async Task UpdateAsync(Sims input)
    {
        _context.Sims.Update(input);
        await _context.SaveChangesAsync();
    }
}