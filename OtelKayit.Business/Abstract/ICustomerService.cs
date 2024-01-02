using OtelKayit.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelKayit.Business.Abstract
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        void Delete(Customer customer);
        List<Customer> GetAll();
        List<Customer> GetCustomersByCustomerName(string customerName);
        void Update(Customer customer);
    }
}
