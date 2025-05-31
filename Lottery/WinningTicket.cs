using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryArchive
{
    public class WinningTicket : Ticket
    {
        public decimal Prize { get; private set; }

        public WinningTicket(string number, decimal prize)
            : base(number, prize)
        {
            Prize = prize;
        }
    }
}
