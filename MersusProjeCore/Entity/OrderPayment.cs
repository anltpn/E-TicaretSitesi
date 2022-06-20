using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MersusProjeCore.Entity
{
    public class OrderPayment : EntityBase
    {
        public int OrderID { get; set; }
        public _OrderType OrderType { get; set; }
        public decimal Price { get; set; }
        public string Bank { get; set; }


    }
    public enum _OrderType
    {
        Havele=0,
        Kredikarti = 1
    }
}
