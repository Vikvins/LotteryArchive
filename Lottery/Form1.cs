using LotteryArchive;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace LotteryArchive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStartLottery_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int ticketLength = (int)numericUpDown1.Value;
            decimal prize = numericUpDown2.Value;
            int participantCount = (int)numericUpDown3.Value;



            // Создаём лотерею
            var lottery = new Lottery(name, ticketLength, prize, totalTickets: participantCount * 2);

            // Генерация участников с рандомными параметрами
            Random rnd = new Random();
            for (int i = 0; i < participantCount; i++)
            {
                var p = new Participant($"Имя{i + 1}", $"Фамилия{i + 1}", rnd.Next(18, 60));
                p.Greediness = rnd.NextDouble() * 0.5 + 0.3; // от 0.3 до 0.8
                p.Refund(1000); // пополняем баланс
                lottery.AddParticipant(p);
            }

            // Генерация билетов
            for (int i = 0; i < lottery.TotalTickets; i++)
            {
                string number = rnd.Next(0, (int)Math.Pow(10, ticketLength)).ToString($"D{ticketLength}");
                decimal price = rnd.Next(100, 501); // 100–500
                lottery.AllTickets.Add(new Ticket(number, price));
            }

            // Запускаем лотерею
            lottery.SellTicketsToParticipants();

            // Вывод результата
            if (lottery.Winner != null)
            {
                lblResult.Text = $"Победитель: {lottery.Winner.Name} {lottery.Winner.Surname}, выигрыш: {lottery.WinningTicket.Prize}₽";
            }
            else
            {
                lblResult.Text = "Лотерея отменена (продано <25% билетов)";
            }
        }

    }
}
