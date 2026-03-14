using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP06
{
    internal class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }

        private decimal _serviceFee = 50;
        public decimal ServiceFee 
        {
            get { return _serviceFee; }
        }
        public VIPTicket(string movieName, decimal price , bool loungeAccess) : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
        }
        

        public override void Print()
        {
            string lounge = LoungeAccess ? "Yes" : "No";
            string bookedStatus = IsBooked ? "Yes" : "No";
            Console.WriteLine( $"Ticket #{TicketId} | {MovieName} | VIP | Lounge: {lounge} | Fee: {ServiceFee} EGP | Price: {Price} EGP | Final: {CalculateFinalPrice():F2} EGP | Booked: {bookedStatus}");
        }

        public override object Clone()
        {
            VIPTicket clone = new VIPTicket(this.MovieName, this.Price, this.LoungeAccess);
            return clone;
        }
        public override decimal CalculateFinalPrice()
        {
            decimal totalWithFee = Price + ServiceFee;  
            return totalWithFee + (totalWithFee * 0.14m);
        }

        public override string GetTicketType()
        {
            return "VIPTicket";
        }
    }
}
