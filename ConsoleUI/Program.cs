using Business.Concrete;
using Core.Adapters;
using Core.CrossCuttingConcerns.Logging.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.NHibernate;
using Entities.Concrete;
using System;

namespace ConsoleUI
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal(), new FileLogger());
            customerManager.Save(new Customer());
        }
    }
}