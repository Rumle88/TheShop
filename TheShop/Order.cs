﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheShop
{
    public class Order
    {
        public int OrderId {get;set;}
        public string OrderName { get; set;}
        public string OrderInfo { get; set; }
        public string OrderType { get; set; }
        public int OrderFlag { get; set; }
    }
}
