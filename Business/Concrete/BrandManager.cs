using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.AddedMessage);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.DeletedMessage);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            var res = _brandDal.GetAll();
            return new SuccessDataResult<List<Brand>>(res,Messages.SuccessListedMessage);
        }

        public IDataResult<Brand> GetById(int id)
        {
            var res = _brandDal.Get(b=>b.id == id);
            return new SuccessDataResult<Brand>(res,Messages.SuccessListedMessage);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.UpdatedMessage);
        }
    }
}