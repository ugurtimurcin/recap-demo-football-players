using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ClubManager : IClubService
    {
        private readonly IClubDal _clubDal;

        public ClubManager(IClubDal clubDal)
        {
            _clubDal = clubDal;
        }

        public async Task<IResult> AddAsync(Club entity)
        {
            await _clubDal.AddAsync(entity);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(Club entity)
        {
            await _clubDal.DeleteAsync(entity);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<Club>>> GetAllAsync()
        {
            return new SuccessDataResult<List<Club>>(await _clubDal.GetAllAsync());
        }

        public async Task<IDataResult<Club>> GetByIdAsync(int id)
        {
            return new SuccessDataResult<Club>(await _clubDal.GetAsync(x => x.Id == id));
        }

        public async Task<IResult> UpdateAsync(Club entity)
        {
            await _clubDal.UpdateAsync(entity);
            return new SuccessResult();
        }
    }
}
