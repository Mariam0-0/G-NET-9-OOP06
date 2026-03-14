using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP06
{
    internal partial class Cinema
    {
        public void PrintAllTickets()
        {
            Console.WriteLine("\n--- All Tickets (from Cinema.Reporting) ---");
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] != null)
                {
                    tickets[i].Print();
                }
            }
            Console.WriteLine();
        }

        public static void ProcessTicket(Ticket t)
        {
            t.Print();
        }

        public void PrintTicketSummary()
        {
            Console.WriteLine("\n--- Ticket Summary ---");
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] != null)
                {
                    string status = tickets[i].IsBooked ? "Booked" : "Available";
                    Console.WriteLine($"Ticket #{tickets[i].TicketId}: {tickets[i].MovieName} - {status}");
                }
            }
            Console.WriteLine();
        }
    }
}

