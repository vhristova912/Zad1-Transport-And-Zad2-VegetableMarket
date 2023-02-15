using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegetableMarket.Model;
using VegetableMarket.Views;

namespace VegetableMarket.Controllers
{
    public class VegetableController
    {
        private Display display;
        private Vegetables vegetables;
        public VegetableController()
        {
            display = new Display();
            vegetables = new Vegetables(display.PriceKgVegetables, display.PriceKgFruits, display.AllKgVegetables, display.AllKgFruits);
            display.TotalPrice = vegetables.PriceOfFood();
            display.ShowPrice();
        }
    }
}
