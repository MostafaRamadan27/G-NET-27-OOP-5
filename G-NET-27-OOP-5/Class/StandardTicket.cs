
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_5
{
    internal class StandardTicket : Ticket, IPrintInfo , ICloneable
    {
        public string SeatNumber { get; set; }
        public StandardTicket( string movieName, decimal price , string seatNumber) : base( movieName, price)
        {
            SeatNumber = seatNumber;
        }
        //public override void PrintTicket()
        //{
        //    base.PrintTicket();
        //    Console.WriteLine($"SeatNumber {SeatNumber}");
        //}

        public void PrintInfo()
        {
            Console.WriteLine($"TicketID {TicketId} Movie Name {MovieName} price {Price} PriceAfterTax {PriceAfterTax}");
            Console.WriteLine($"SeatNumber {SeatNumber}");
        }
        public object Clone()
        {
            return new StandardTicket(MovieName, Price , SeatNumber);
        }
    }
}
