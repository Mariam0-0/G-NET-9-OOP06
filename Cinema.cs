using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP06

{
    internal partial class Cinema
    {

        public string CinemaName { get; set; }
        public Projector projector = new Projector();


        private Ticket[] tickets = new Ticket[20];

        public void OpenCinema()
        {
            Console.WriteLine("\n=== Cinema Opened ===");
            StartProjector();
        }

        public void CloseCinema()
        {
            StopProjector();
            Console.WriteLine("=== Cinema Closed ===\n");
        }

        public void StartProjector()
        {
            projector.Start();
        }

        public void StopProjector()
        {
            projector.Stop();
        }

    }
}

