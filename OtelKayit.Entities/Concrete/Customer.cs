
using Microsoft.OData.Edm;
using OtelKayit.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelKayit.Entities.Concrete
{
    public class Customer:IEntity
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerTC { get; set; }
        public int Price { get; set; }
        public int OdaNo { get; set; }
        public DateTime GirisTarihi  { get; set; }
        public DateTime CikisTarihi { get; set; }



    }
}
