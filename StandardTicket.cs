using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP06
{
    internal class StandardTicket : Ticket
    {

        public string SeatNumber { get; set; }
        public StandardTicket(string movieName, decimal price, string seatNum) : base(movieName, price)
        {
            SeatNumber = seatNum;
        }
        
        public override void Print()
        {
            string bookedStatus = IsBooked ? "Yes" : "No";
            Console.WriteLine( $"Ticket #{TicketId} | {MovieName} | Standard | Seat: {SeatNumber} | Price: {Price} EGP | Final: {CalculateFinalPrice():F2} EGP | Booked: {bookedStatus}");
        }
        public override object Clone()
        {
            StandardTicket clone = new StandardTicket(this.MovieName, this.Price, this.SeatNumber);
            return clone;
        }
        public override decimal CalculateFinalPrice()
        {
            return PriceAfterTax;
        }

        public override string GetTicketType()
        {
            return "Standard";
        }

    }
}
