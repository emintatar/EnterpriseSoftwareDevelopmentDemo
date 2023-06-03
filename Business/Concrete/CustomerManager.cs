using Business.Abstract;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Logging.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        ILogger _logger;
        public CustomerManager(ICustomerDal customerDal, ILogger logger)
        {
            _customerDal = customerDal;
            _logger = logger;
        }
      
        public void Save(Customer customer)
        {
            _customerDal.Save();
            _logger.Log();
        }
    }
}
