using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP06
{
    internal abstract class Ticket : IPrintable, IBookable, ICloneable
    {

        #region Old Methods & Fields


        private string _movieName;
        public string MovieName 
        {
            get { return _movieName; }
            set 
            { 
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Movie Name cannot be null or empty");
                    return;
                }
                _movieName = value;
            } 
        }

        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Price must be > 0");
                    return;
                }
                _price = value;
            }
        }

        private static int ticketCounter = 0;
        private int _ticketId;
        public int TicketId
        {
            get { return _ticketId; }
        }

        
        public Ticket(string movieName, decimal price)
        {
            MovieName = movieName;
            Price = price;
            _ticketId = ++ticketCounter;
            IsBooked = false;
        }
        
        public decimal PriceAfterTax
        {
            get { return _price + _price * 0.14m; }
        }
        

      
        public static int GetTotalTicketsSold()
        {
            return ticketCounter;
        }


        

        public void SetPrice(decimal price)
        {
            Price = price;
        }
        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            Price = basePrice * multiplier;
        }
        #endregion

        public bool IsBooked { get; set; }
        public abstract void Print();


        public virtual bool Book()
        {
            if (IsBooked)
            {
                Console.WriteLine($"Ticket #{TicketId} is already booked!");
                return false;
            }

            IsBooked = true;
            return true;
        }

        public virtual bool Cancel()
        {
            if (!IsBooked)
            {
                Console.WriteLine($"Ticket #{TicketId} is not booked, cannot cancel!");
                return false;
            }

            IsBooked = false;
            return true;
        }
        public virtual object Clone()
        {
            Ticket clone = (Ticket)this.MemberwiseClone();
            return clone;
        }
        public abstract decimal CalculateFinalPrice();
        public virtual string GetTicketType()
        {
            return "Ticket";
        }

    }
}
