using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PlayerManager : IPlayerService
    {
        private readonly IPlayerDal _playerDal;
        public PlayerManager(IPlayerDal playerDal)
        {
            _playerDal = playerDal;
        }

        public async Task<IResult> AddAsync(Player entity)
        {
            await _playerDal.AddAsync(entity);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(Player entity)
        {
            await _playerDal.DeleteAsync(entity);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<Player>>> GetAllAsync()
        {
            return new SuccessDataResult<List<Player>>(await _playerDal.GetAllAsync());
        }

        public async Task<IDataResult<Player>> GetByIdAsync(int id)
        {
            return new SuccessDataResult<Player>(await _playerDal.GetAsync(x=>x.Id == id));
        }

        public async Task<IResult> UpdateAsync(Player entity)
        {
            await _playerDal.UpdateAsync(entity);
            return new SuccessResult();
        }
    }
}
