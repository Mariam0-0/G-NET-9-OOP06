using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP06
{
    internal static class TicketExtension
    {
        public static string GenerateReceipt(this Ticket ticket)
        {
            return $@"
========== RECEIPT ==========
Movie : {ticket.MovieName}
Type : {ticket.GetTicketType()}
Price : {ticket.Price}
Final : {ticket.CalculateFinalPrice():F2}
Status : {(ticket.IsBooked ? "Booked" : "Available")}
=============================";
        }

        public static decimal CalculateTotalRevenue(this Ticket[] tickets)
        {
            if (tickets == null || tickets.Length == 0)
                return 0;

            return tickets.Where(t => t != null && t.IsBooked)
                          .Sum(t => t.CalculateFinalPrice());
        }

        public static int GetBookedCount(this Ticket[] tickets)
        {
            return tickets?.Count(t => t != null && t.IsBooked) ?? 0;
        }
    }
}
