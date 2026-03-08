using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_7_OOP04
{
    public class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(string movieName, bool is3D) : base(movieName)
        {
            Is3D = is3D;
        }

        public override void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
            Console.WriteLine($"IMAX 3D: {(Is3D ? "Yes" : "No")}");
        }
    }
}
