using System.Buffers;
using System.Runtime.InteropServices;

namespace G_NET_27_OOP_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions

            #region Q1
            // interface is Contract that class must follow , it specifies what class can do no what how does it , because tight coupling and hard to test , hard to change
            // 1-enable multiable inheritance
            // 2- enable polymorphism without inheritance
            // 3- remove tight coupling between classes  

            #endregion

            #region Q2
            // A) IEnglishSpeaker and IArabicSpeaker exact same thing we cant give them different brhavior 
            // print same result in both cases
            // B) Explicit implementation 
            //C) yes can call Translator.Greet() we call each version by Cast interface first 
            //like Translator translator = new Translator();
            //IEnglishSpeaker englishSpeaker = translator;
            // englishSpeaker.Greet(); // Calls IEnglishSpeaker's Greet method
            // IArabicSpeaker arabicSpeaker = translator;
            // arabicSpeaker.Greet(); // Calls IArabicSpeaker's Greet method
            #endregion

            #region Q3
            // Shallow copy the object but copies reference for reference type field 
            // Deepcopy copy object and all nested object
            //SHallow => object is immutable ,no nested reference state , perfomance is critical
            //deepcopy => object must isolated , modification should not affect original object
            // modification will affect original object
            #endregion



            #region Q4
            // e1  => {  Dev,  Testing} };
            // e2 => { QA,Testing } };
            // because in shallow copy copy the reference refer to object not the object itself so both e1 and e2 refer to same object in memory so any change in one will reflect in other
            #endregion
            #endregion


            #region Part 02 : Practical (Extending the Movie Ticket Booking System)

            Cinema cinema = new Cinema("Cineplex");
            cinema.OpenCinema();
            Ticket ticket01 = new StandardTicket("Inception", 120.0m, "A-5");

            Ticket ticket02 = new VIPTicket("Avengers", 200.0m, true);

            Ticket ticket03 = new IMAXTicket("Avatar", 180.0m, true);

            Console.WriteLine(ticket01.SetPrice(250));
            Console.WriteLine(ticket02.SetPrice(250, 4));

            cinema.AddTicket(ticket01);
            cinema.AddTicket(ticket02);
            cinema.AddTicket(ticket03);

            cinema.PrintAllTickets();
            Console.WriteLine("All Ticket");
            // d. Clone VIP ticket
            Ticket clonedVIP = (Ticket)ticket02.Clone();
            clonedVIP.MovieName = "Joker";


            Console.WriteLine("Original VIP Ticket:");
            ticket02.PrintInfo();

            Console.WriteLine("Cloned VIP Ticket:");
            clonedVIP.PrintInfo();

            Console.WriteLine("Cancel standard Ticket:");
            ticket01.CancelBooking();
            ticket01.PrintInfo();


            Console.WriteLine("Printing using BookingHelper:");
            IPrintInfo[] tickets = { ticket01, ticket02, ticket03, clonedVIP };
            BookingHelper(tickets);
            Console.WriteLine("Book standard Ticket:");
            ticket01.BookTicket();
            ticket01.PrintInfo();
            Console.WriteLine("Cancel standard Ticket:");
            ticket01.CancelBooking();
            ticket01.PrintInfo();


            cinema.CloseCinema();



            #endregion
        }

        public static void BookingHelper(IPrintInfo[] printInfo)
        {
            foreach (var item in printInfo)
            {
                item.PrintInfo();

            }
        }
    }
}
