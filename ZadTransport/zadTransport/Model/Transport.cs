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
        public int Km
        {
            get { return this.km; }
            set
            {
                this.km = value;
            }
        }
        public string Time
        {
            get { return this.time; }
            set
            {
                this.time = value;
            }
        }

        public double CalculatePrice()
        {
            double price = 0;
            double startPrice = 0;
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
            return price+startPrice*this.Km;
        }
        
    }
}
