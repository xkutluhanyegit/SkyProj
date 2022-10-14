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
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public IResult Add(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult(Messages.AddedMessage);
        }

        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult(Messages.DeletedMessage);
        }

        public IDataResult<List<Order>> GetAll()
        {
            var res = _orderDal.GetAll();
            return new SuccessDataResult<List<Order>>(res,Messages.SuccessListedMessage);
        }

        public IDataResult<Order> GetById(int id)
        {
            var res = _orderDal.Get(o=>o.ID == id);
            return new SuccessDataResult<Order>(res,Messages.SuccessListedMessage);
        }

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult(Messages.UpdatedMessage);
        }
    }
}