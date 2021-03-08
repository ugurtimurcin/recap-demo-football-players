using Core.Utilities.Results;
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPlayerService
    {
        Task<IDataResult<Player>> GetByIdAsync(int id);
        Task<IDataResult<List<Player>>> GetAllAsync();
        Task<IResult> AddAsync(Player entity);
        Task<IResult> UpdateAsync(Player entity);
        Task<IResult> DeleteAsync(Player entity);
    }
}
