using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket.Model
{
    public class Vegetables
    {
        private double priceKgVegetables;
        private double priceKgFruits;
        private int allKgVegetables;
        private int allKgFruits;

        public Vegetables(double priceKgVegetables, double priceKgFruits, int allKgVegetables, int allKgFruits)
        {
            this.PriceKgVegetables = priceKgVegetables;
            this.PriceKgFruits = priceKgFruits;
            this.AllKgVegetables = allKgVegetables;
            this.AllKgFruits = allKgFruits;
        }
        public double PriceKgVegetables { get; set; }
        public double PriceKgFruits { get; set; }
        public int AllKgVegetables { get; set; }
        public int AllKgFruits { get; set; }

        public double PriceOfFood()
        {
            double totalPrice = 0;
            double vegetablesPrice = 0;
            double fruitPrice = 0;
            fruitPrice = PriceKgFruits * AllKgFruits;
            vegetablesPrice = PriceKgVegetables * AllKgVegetables;
            totalPrice = (vegetablesPrice + fruitPrice) / 1.94;
            return totalPrice;
        }
    }
}
