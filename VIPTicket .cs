using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_7_OOP04
{
    public class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }

        public decimal ServiceFee { get; set; }

        public VIPTicket(string movieName, bool loungeAccess, decimal serviceFee) : base(movieName)
        {
            LoungeAccess = loungeAccess;
            ServiceFee = serviceFee;
        }

        public override void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
            Console.WriteLine($"Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP");
        }
    }
}
