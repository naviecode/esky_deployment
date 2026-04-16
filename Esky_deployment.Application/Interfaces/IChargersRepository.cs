using Esky_deployment.Application.Common;
using Esky_deployment.Domain.Entities;

namespace Esky_deployment.Infrastructure.Repositories;

public interface IChargersRepository
{
    Task<PaginationResult<Chargers>> GetAllAsync(int page, int pageSize);

    Task<Chargers?> GetByIdAsync(int id);

    Task<Chargers> CreateAsync(Chargers charger);

    Task UpdateAsync(Chargers charger);

    Task DeleteAsync(Chargers charger);
}
