using Esky_deployment.Application.Common;
using Esky_deployment.Domain.Entities;

namespace Esky_deployment.Esky_deployment.Application.Interfaces;

public interface ISimPackageRepository
{
    Task<PaginationResult<SimPackages>> GetAllAsync(int page, int pageSize);
    Task<SimPackages?> GetByIdAsync(int id);
    Task<SimPackages> CreateAsync(SimPackages input);
    Task UpdateAsync(SimPackages input);
    Task DeleteAsync(SimPackages input);
}