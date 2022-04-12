using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Order
    {
        public int No { get; set; }
        public int ProductCount { get; set; }
        public double TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; } 
    }
}
