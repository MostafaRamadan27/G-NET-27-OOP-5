using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_5
{
    internal class Ticket : IPrintInfo, ICloneable
    {
        private static int _counter = 0;
        protected bool IsBooked = false;
        public int TicketId { get; set; }
        public string MovieName { get; set; }
        public decimal Price { get; set; }

        public decimal PriceAfterTax { get; set; }
        public Ticket( string movieName , decimal price ) 
        {
         
            MovieName = movieName;
            Price = price;
            PriceAfterTax = price * 0.14m; 
            TicketId = ++_counter;
        }

        //public virtual void PrintTicket() 
        //{
        //    Console.WriteLine($"TicketId {TicketId} ");
        //    Console.WriteLine($"MovieName {MovieName} ");
        //    Console.WriteLine($"price {Price}");
        //    Console.WriteLine($"Price After Tax {PriceAfterTax}");
        //}

        public decimal SetPrice(decimal price) => price;
        public decimal SetPrice(decimal price, decimal multiplier) => price * multiplier;

        public void PrintInfo()
        {
            Console.WriteLine($"TicketID {TicketId} Movie Name {MovieName} price {Price} PriceAfterTax {PriceAfterTax}");
        }

        public object Clone()
        {
            return new Ticket(MovieName,Price);
        }

        //public override string ToString()
        //{
        //    return $"TicketID {TicketId} Movie Name {MovieName} price {Price} PriceAfterTax {PriceAfterTax}"; 
        //}
        public bool BookTicket()
        {
            if (IsBooked)
            {
                Console.WriteLine("Booking failed: Ticket already booked.");
                return false;
            }
            IsBooked = true;
            Console.WriteLine("Booking Success");
            return true;
        }

        public bool CancelBooking()
        {
            if (!IsBooked)
            {
                Console.WriteLine("Cancellation failed: Ticket is not booked.");
                return false;
            }
            IsBooked = false;
            Console.WriteLine("Cancellation Success");
            return true;
        }
    }
}
