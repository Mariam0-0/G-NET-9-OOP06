using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP06
{
    internal class IMAXTicket : Ticket
    {

        //c.IMAXTicket — prints the base ticket info and whether it is 3D.

        public bool Is3D { get; set; }
        public IMAXTicket(string movieName, decimal price, bool is3d) : base(movieName, price)
        {
            Is3D = is3d;
           
        }

        
        public override void Print()
        {
            string is3d = Is3D ? "Yes" : "No";
            string bookedStatus = IsBooked ? "Yes" : "No";
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | IMAX | 3D: {is3d} | Price: {Price} EGP | Final: {CalculateFinalPrice():F2} EGP | Booked: {bookedStatus}");
        }

        public override object Clone()
        {
            IMAXTicket clone = new IMAXTicket(this.MovieName, this.Price, this.Is3D);
            return clone;
        }
    

        public override decimal CalculateFinalPrice()
        {
            return PriceAfterTax ;
        }

        public override string GetTicketType()
        {
            return "IMAXTicket";
        }
    }
}
