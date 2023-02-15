using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket.Views
{
    public class Display
    { 
        public Display()
        {
            this.PriceKgVegetables = 0;
            this.PriceKgFruits = 0;
            this.AllKgFruits = 0;
            this.AllKgVegetables = 0;
            this.TotalPrice = 0;
            this.GetValues();
            
        }
        public double PriceKgVegetables { get; set; }
        public double PriceKgFruits { get; set; }
        public double TotalPrice { get; set; }
        public int AllKgVegetables { get; set; }
        public int AllKgFruits { get; set; }
        
        public void GetValues()
        {
            Console.WriteLine("Enter vegetable price:");
            this.PriceKgVegetables = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter fruit price:");
            this.PriceKgFruits = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter vegetable kg:");
            this.AllKgVegetables = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fruit kg:");
            this.AllKgFruits = int.Parse(Console.ReadLine());
        }
        public void ShowPrice()
        {
            Console.WriteLine($"Total price is: {this.TotalPrice}");
        }
    }
}
