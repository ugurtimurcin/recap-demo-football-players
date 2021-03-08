using Core.Utilities.Results;
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPositionService
    {
        Task<IDataResult<Position>> GetByIdAsync(int id);
        Task<IDataResult<List<Position>>> GetAllAsync();
        Task<IResult> AddAsync(Position entity);
        Task<IResult> UpdateAsync(Position entity);
        Task<IResult> DeleteAsync(Position entity);
    }
}
