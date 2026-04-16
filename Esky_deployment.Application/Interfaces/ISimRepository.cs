using Esky_deployment.Application.Common;
using Esky_deployment.Domain.Entities;

namespace Esky_deployment.Esky_deployment.Application.Interfaces;

public interface ISimRepository
{
    Task<PaginationResult<Sims>> GetAllAsync(int page, int pageSize);
    Task<Sims?> GetByIdAsync(int id);
    Task<Sims> CreateAsync(Sims input);
    Task UpdateAsync(Sims input);
    Task DeleteAsync(Sims input);
}

