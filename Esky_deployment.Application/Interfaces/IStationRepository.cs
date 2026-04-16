using Esky_deployment.Application.Common;
using Esky_deployment.Domain.Entities;

namespace Esky_deployment.Application.Interfaces;

public interface IStationRepository
{
    Task<PaginationResult<Station>> GetAllAsync(int page, int pageSize);
    Task<Station?> GetByIdAsync(int id);
    Task<Station> CreateAsync(Station input);
    Task UpdateAsync(Station input);
    Task DeleteAsync(Station input);
}