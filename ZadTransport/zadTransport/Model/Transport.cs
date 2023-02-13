using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadTransport.Model
{
    public class Transport
    {
        private int km;
        private string time;
        

        public Transport(int km, string time)
        {
            this.Km = km;
            this.Time = time;
        }
        public Transport():this(0,"")
        {

        }
        public int Km { get; set; }
        public string Time { get; set; }

        public double CalculatePrice()
        {
            double startPrice = 0;
            double price = 0;
            if (this.Km<20)
            {
                startPrice = 0.70;
                if (this.Time =="day")
                {
                     price=0.79;
                }
                else 
                {
                     price= 0.9;
                }
            }
            else if (this.Km <100)
            {
                {
                     price = 0.09;
                }
            }
            else
            {
                price =  0.06;
            }
            return startPrice+price*this.Km;
        }
        
    }
}
