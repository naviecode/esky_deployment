using Esky_deployment.Application.Common;
using Esky_deployment.Application.Interfaces;
using Esky_deployment.Domain.Entities;
using Esky_deployment.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Esky_deployment.Esky_deployment.Infrastructure.Repositories;

public class StationRepository : IStationRepository
{
    private readonly AppDbContext _context;

    public StationRepository(AppDbContext context)
    {
        this._context = context;
    }

    public async Task<Station> CreateAsync(Station input)
    {
        await _context.Stations.AddAsync(input);
        await _context.SaveChangesAsync();
        return input;
    }

    public async Task DeleteAsync(Station input)
    {
        _context.Stations.Remove(input);
        await _context.SaveChangesAsync();
    }

    public async Task<PaginationResult<Station>> GetAllAsync(int page, int pageSize)
    {
        var query = _context.Stations.AsNoTracking();

        var total = await query.CountAsync();

        var items = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        
        return new PaginationResult<Station>
        {
            Page = page,
            PageSize = pageSize,
            TotalItems = total,
            Items = items
        };
    }

    public async Task<Station?> GetByIdAsync(int id)
    {
        return await _context.Stations.FirstOrDefaultAsync(x=>x.Id == id);
    }

    public async Task UpdateAsync(Station input)
    {
        _context.Stations.Update(input);
        await _context.SaveChangesAsync();
    }
}