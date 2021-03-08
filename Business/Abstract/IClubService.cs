using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IClubService
    {
        Task<IDataResult<Club>> GetByIdAsync(int id);
        Task<IDataResult<List<Club>>> GetAllAsync();
        Task<IResult> AddAsync(Club entity);
        Task<IResult> UpdateAsync(Club entity);
        Task<IResult> DeleteAsync(Club entity);
    }
}
