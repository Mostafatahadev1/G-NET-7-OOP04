using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_7_OOP04
{
    public class Ticket
    {

        private static int ticketCounter = 0;

        public int TicketId { get; }

        public string MovieName { get; set; }

        protected decimal Price;

        public decimal PriceAfterTax
        {
            get { return Price * 1.14m; }
        }

        public Ticket(string movieName)
        {
            ticketCounter++;
            TicketId = ticketCounter;
            MovieName = movieName;
        }

        public void SetPrice(decimal price)
        {
            Price = price;
        }

        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            Price = basePrice * multiplier;
        }

        
        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
        }
    }
}
