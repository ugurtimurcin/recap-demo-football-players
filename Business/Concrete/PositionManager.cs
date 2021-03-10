using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PositionManager : IPositionService
    {
        private readonly IPositionDal _positionDal;

        public PositionManager(IPositionDal positionDal)
        {
            _positionDal = positionDal;
        }

        [ValidationAspect(typeof(PositionValidator))]
        public async Task<IResult> AddAsync(Position entity)
        {
            await _positionDal.AddAsync(entity);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(Position entity)
        {
            await _positionDal.DeleteAsync(entity);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<Position>>> GetAllAsync()
        {
            return new SuccessDataResult<List<Position>>(await _positionDal.GetAllAsync());
        }

        public async Task<IDataResult<Position>> GetByIdAsync(int id)
        {
            return new SuccessDataResult<Position>(await _positionDal.GetAsync(x => x.Id == id));
        }

        [ValidationAspect(typeof(PositionValidator))]
        public async Task<IResult> UpdateAsync(Position entity)
        {
            await _positionDal.UpdateAsync(entity);
            return new SuccessResult();
        }
    }
}
