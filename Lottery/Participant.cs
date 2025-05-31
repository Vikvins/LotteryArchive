using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace LotteryArchive
{
    public partial class Participant : Person
    {
        public List<Ticket> Tickets { get; private set; }

        public Participant(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
            Tickets = new List<Ticket>();
        }

        public void AddTicket(Ticket ticket)
        {
            Tickets.Add(ticket);
        }
    }

    public partial class Participant
    {
        public double Greediness { get; set; }
        public decimal Balance { get; private set; }
        public bool CanBuyTicket(decimal price)
        {
            if (Balance >= price)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SpendMoney(decimal price)
        {
            Balance -= price;
        }

        public void Refund(decimal price)
        {
            Balance += price;
        }
    }
}
