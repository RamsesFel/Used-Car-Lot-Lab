using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Used_Car_Lot_Lab
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        //constructor 
        public Car()
        {

            Make = "";
            Model = "";
            Year = 0;
            Price = 0m;
        }
        public Car(string _make, string _model, int _year, decimal _price)
        {
            Make = _make;
            Model = _model;
            Year = _year;
            Price = _price;
        }
        public override string ToString()
        {
            return $"{Make} {Model} {Year} {Price}";
        }
    }
}
