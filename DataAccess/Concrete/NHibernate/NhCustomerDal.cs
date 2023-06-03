using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.NHibernate
{
    public class NhCustomerDal : ICustomerDal
    {
        public void Save()
        {
            Console.WriteLine("Customer added to database with NHibernate.");
        }
    }
}
