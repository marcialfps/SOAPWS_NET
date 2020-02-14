using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS.Unit05.Example2.Application.Model
{
    public class Product
    {
        public string Name { get; set; }
        public double ProductPrice { get; set; }
        public double ShippingPrice { get; set; }
        public double FinalPrice => (ProductPrice + ShippingPrice) * 1.20;
        public long Visits { get; set; }
    }
}