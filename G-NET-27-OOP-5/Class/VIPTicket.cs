
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_5
{
    internal class VIPTicket : Ticket , IPrintInfo , ICloneable
    {
        public bool LoungAccess { get; set; }
        public decimal ServiceFee { get; } = 50;
        public VIPTicket(string movieName, decimal price, bool loungAccess) : base(movieName, price)
        {
            price = price + ServiceFee;
            LoungAccess = loungAccess;
        }
        //public override void PrintTicket()
        //{
        //    base.PrintTicket();
        //    Console.WriteLine($"LoungAccess {LoungAccess}");
        //    Console.WriteLine($"ServiceFee {ServiceFee}");
        //}

        public object Clone()
        {
            return new VIPTicket(MovieName, Price , LoungAccess);
        }
        public void PrintInfo()
        {
            Console.WriteLine($"TicketID {TicketId} Movie Name {MovieName} price {Price} PriceAfterTax {PriceAfterTax}");
            Console.WriteLine($"LoungAccess {LoungAccess}");
            Console.WriteLine($"ServiceFee {ServiceFee}");
        }
    }
}
