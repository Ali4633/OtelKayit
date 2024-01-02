using OtelKayit.DataAccess.Abstract;
using OtelKayit.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OtelKayit.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer,OtelKayitContext>,ICustomerDal //implemenate ile inheritance alıyoruz
    {
        

       
    }
}
