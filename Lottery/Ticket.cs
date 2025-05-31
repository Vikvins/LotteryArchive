using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryArchive
{
    public class Ticket
    {
        public decimal Price { get; private set; }

        public string Number { get; private set; }

        public Ticket(string number, decimal price)
        {
            Number = number;
            Price = price;
        }
    }
}
