using OtelKayit.Business.Abstract;
using OtelKayit.DataAccess.Abstract;
using OtelKayit.DataAccess.Concrete;
using OtelKayit.DataAccess.Concrete.EntityFramework;
using OtelKayit.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelKayit.Business.Concrete
{
    public class CustomerManager:ICustomerService
    {
        //dependency injection yapıyoruz
        private ICustomerDal _customerdal;

        public CustomerManager(ICustomerDal customerdal)
        {
            _customerdal = customerdal;
        }

        public void Add(Customer customer)
        {
            _customerdal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customerdal.Delete(customer);
        }

        public List<Customer> GetAll()
        {
            // Business codelarım
            return _customerdal.GetAll();
            
        }

        public List<Customer> GetCustomersByCustomerName(string customerName)
        {
            return _customerdal.GetAll(p=>p.CustomerName.ToLower().Contains(customerName.ToLower()));
        }

        public void Update(Customer customer)
        {
            _customerdal.Update(customer);
        }
    }
}
