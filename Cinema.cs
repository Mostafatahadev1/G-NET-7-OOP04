using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_7_OOP04
{
    public class Cinema
    {
        private Ticket[] tickets = new Ticket[20];

        public void AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return;
                }
            }
        }

        public void PrintAllTickets()
        {
            foreach (var t in tickets)
            {
                if (t != null)
                    t.PrintTicket();
            }
        }

        public void Open()
        {
            Console.WriteLine("========= Cinema Opened =========");
            Console.WriteLine("Projector started.\n");
        }

        public void Close()
        {
            Console.WriteLine("\n========= Cinema Closed =========");
        }

        public static void ProcessTicket(Ticket t)
        {
            Console.WriteLine("\n===== Process Single Ticket =====");
            t.PrintTicket();
        }
    }
}
