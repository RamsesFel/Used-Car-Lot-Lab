using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Used_Car_Lot_Lab;

public class UsedCar:Car
{
    public double Mileage { get; set; }
    public UsedCar(string _make, string _model, int _year, decimal _price, double _mileage) : base(_make, _model, _year, _price)
    {
        Mileage = _mileage;
    }

    public override string ToString()
    {
        return $"Used {Make} {Model} {Year} {Price} {Mileage}";
    }

   

}
