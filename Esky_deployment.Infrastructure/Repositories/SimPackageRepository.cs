using Esky_deployment.Application.Common;
using Esky_deployment.Domain.Entities;
using Esky_deployment.Esky_deployment.Application.Interfaces;
using Esky_deployment.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Esky_deployment.Esky_deployment.Infrastructure.Repositories;


public class SimPackageRepository : ISimPackageRepository
{
    private readonly AppDbContext _context;
    public SimPackageRepository(AppDbContext context)
    {
        this._context = context;
    }
    public async Task<SimPackages> CreateAsync(SimPackages input)
    {
        await _context.SimPackages.AddAsync(input);
        await _context.SaveChangesAsync();

        return input;
    }

    public async Task DeleteAsync(SimPackages input)
    {
        _context.SimPackages.Remove(input);
        await _context.SaveChangesAsync();
    }

    public async Task<PaginationResult<SimPackages>> GetAllAsync(int page, int pageSize)
    {
        var query = _context.SimPackages.AsNoTracking();

        var total = await query.CountAsync();

        var items = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

        return new PaginationResult<SimPackages>
        {
          Page = page,
          PageSize = pageSize,
          TotalItems = total,
          Items = items  
        };
    }

    public Task<SimPackages?> GetByIdAsync(int id)
    {
        return _context.SimPackages.FirstOrDefaultAsync(x=>x.Id == id);
    }

    public async Task UpdateAsync(SimPackages input)
    {
        _context.SimPackages.Update(input);
        await _context.SaveChangesAsync();
    }
}