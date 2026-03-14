using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP06

{
    internal static class BookingHelper
    {
        #region Requirments
        //4. Create a static utility class called `BookingHelper` with the following static methods:
        //a. ` double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)` That returns total price with a 10% discount if the group has 5 or more tickets, otherwise returns the full total.
        //b. ` string GenerateBookingReference()` That returns a unique string each time it is called(e.g., "BK-1", "BK-2", "BK-3", ...). Use a private static counter internally.

        #endregion
        
        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            if(numberOfTickets >= 5)
            {
                return pricePerTicket * numberOfTickets - 0.1 * (pricePerTicket * numberOfTickets);
            }
            return pricePerTicket * numberOfTickets;
        }
        private static int counter = 0;
        public static string GenerateBookingReference()
        {
            return $"BK-{++counter}";
        }

        public static void PrintAll(IPrintable[] items)
        {
            Console.WriteLine("--- BookingHelper.PrintAll ---");
            foreach (var item in items)
            {
                item.Print();
            }
            Console.WriteLine();
        }
    }
}
