using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_5
{
    internal class Cinema : IPrintInfo
    {
        private List<Ticket> _tickets = new List<Ticket>();
        private Projector _projector;

        public Cinema(string cinemaName)
        {
            _tickets = new List<Ticket>();
            _projector = new Projector();
            CinemaName = cinemaName;
        }

        public string CinemaName { get; set; }

        public void AddTicket(Ticket t)
        {
            if (_tickets.Count < 20)
            {
                _tickets.Add(t);
            }
            else
            {
                Console.WriteLine("Cinema is full");
            }
        }
        public void PrintAllTickets()
        {
            foreach (var ticket in _tickets)
            {
                Console.WriteLine(ticket);
                ticket.PrintInfo();
            }
        }
        public void OpenCinema()
        {
            Console.WriteLine($"Opening {CinemaName}...");
            _projector.Start();
        }
        public void CloseCinema()
        {
            Console.WriteLine($"Closing {CinemaName}...");
            _projector.Stop();
        }

        public void PrintInfo()
        {
            foreach (var ticket in _tickets)
            {
                Console.WriteLine(ticket);
                ticket.PrintInfo();
            }
        }
    }
}
