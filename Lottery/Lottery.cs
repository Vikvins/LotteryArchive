using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LotteryArchive
{
    public partial class Lottery
    {
        public string LotteryName { get; private set; }
        public int TicketNumberLength { get; private set; }
        public decimal PrizeFund { get; private set; }
        public int TotalTickets { get; private set; }

        public List<Participant> Participants { get; private set; } //участник
        public List<Ticket> AllTickets { get; private set; } //
        public WinningTicket WinningTicket { get; private set; }
        public Participant Winner { get; private set; } // победитель лотереи

        public Lottery(string lotteryName, int ticketNumberLength, decimal prizeFund, int totalTickets)
        {
            LotteryName = lotteryName;
            TicketNumberLength = ticketNumberLength;
            PrizeFund = prizeFund;
            TotalTickets = totalTickets;
            Participants = new List<Participant>();
            AllTickets = new List<Ticket>();
        }

        public void AddParticipant(Participant participant)
        {
            Participants.Add(participant);
        }
    }

    public partial class Lottery
    {
        public void SellTicketsToParticipants()
        {
            int totalTickets = AllTickets.Count; // Всего билетов для продажи
            int soldCount = 0;                   // Счётчик проданных билетов

            // Создаём очередь билетов, чтобы продавать их по порядку
            Queue<Ticket> ticketQueue = new Queue<Ticket>(AllTickets);

            // Перебираем всех участников
            foreach (var participant in Participants)
            {
                // Определяем, сколько билетов хочет купить участник,
                // исходя из его жадности (например, 0.5 * totalTickets)
                int targetBuy = (int)(participant.Greediness * totalTickets);

                // Пока участник хочет купить билеты, билеты ещё есть, и хватает денег
                while (targetBuy > 0 && ticketQueue.Count > 0)
                {
                    // Берём следующий билет из очереди (без использования Peek)
                    Ticket ticket = ticketQueue.Dequeue();

                    // Проверяем, хватает ли у участника денег на этот билет
                    if (participant.CanBuyTicket(ticket.Price))
                    {
                        // Продаём билет участнику
                        participant.AddTicket(ticket);

                        // Снимаем с баланса цену билета
                        participant.SpendMoney(ticket.Price);

                        soldCount++;   // Увеличиваем счётчик проданных билетов
                        targetBuy--;   // Уменьшаем количество билетов, которые участник хочет купить
                    }
                    else
                    {
                        // Если денег не хватает — возвращаем билет обратно в очередь и прекращаем попытки для этого участника
                        ticketQueue.Enqueue(ticket);
                        break;
                    }
                }
            }

            // Проверяем, продано ли достаточно билетов (минимум 25%)
            if (soldCount < totalTickets * 0.25)
            {
                Console.WriteLine("Продано менее 25% билетов. Лотерея отменена. Возврат 90% потраченных денег.");

                // Возвращаем 90% потраченных денег каждому участнику
                foreach (var p in Participants)
                {
                    decimal spent = 0;
                    foreach (var t in p.Tickets)
                    {
                        spent += t.Price;
                    }
                    p.Refund(spent * 0.9m);
                }

                AllTickets.Clear(); // Очищаем список билетов
                return;             // Прекращаем работу метода (лотерея отменена)
            }

            // Если лотерея проходит — выбираем победителя случайно из всех проданных билетов
            List<Ticket> allSoldTickets = new List<Ticket>();
            foreach (var p in Participants)
            {
                allSoldTickets.AddRange(p.Tickets);
            }

            Random rand = new Random();
            Ticket winningTicket = allSoldTickets[rand.Next(allSoldTickets.Count)];

            // Определяем победителя — участника, у которого есть выигрышный билет
            Winner = null;
            foreach (var p in Participants)
            {
                if (p.Tickets.Contains(winningTicket))
                {
                    Winner = p;
                    break;
                }
            }

            // Создаём выигрышный билет с призовым фондом
            WinningTicket = new WinningTicket(winningTicket.Number, PrizeFund);
        }
    }
}
