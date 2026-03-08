using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_7_OOP04
{
    public class StandardTicket :Ticket
    {
        public Seat SeatNumber { get; set; }

        public StandardTicket(string movieName, Seat seat) : base(movieName)
        {
            SeatNumber = seat;
        }

        public override void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
            Console.WriteLine($"Seat: {SeatNumber}");
        }
    }
}
