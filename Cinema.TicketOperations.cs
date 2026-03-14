using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP06
{
    internal partial class Cinema
    {
        public void BookTicket(int ticketId)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] != null && tickets[i].TicketId == ticketId)
                {
                    tickets[i].Book();
                    return;
                }
            }
            Console.WriteLine($"Ticket #{ticketId} not found.");
        }

        public void CancelTicket(int ticketId)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] != null && tickets[i].TicketId == ticketId)
                {
                    tickets[i].Cancel();
                    return;
                }
            }
            Console.WriteLine($"Ticket #{ticketId} not found.");
        }

        public Ticket[] GetAllTickets()
        {
            return tickets;
        }
        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < 20; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return true;
                }
            }
            return false;
        }

    }
}

