using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadTransport.Model;
using zadTransport.View;

namespace zadTransport.Controller
{
   public class TransportPriceController
    {
        private Display display;
        private Transport transport;
        public TransportPriceController()
        {
            display = new Display();
            transport = new Transport(display.Km, display.Time);
            display.TotalPrice = transport.CalculatePrice();
            display.ShowPrice();
        }
    }
}
