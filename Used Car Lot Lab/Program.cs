using System.Threading.Channels;
using Used_Car_Lot_Lab;



    
  
        
        Car Car1 = new Car("Honda", "CRV", 2024, 43000);
        Car Car2 = new Car("Chevy", "Trailblazer", 2024, 27425);
        Car Car3 = new Car("Chevy", "Corvette", 2024, 68300);
        UsedCar car4 = new UsedCar("Toyota", "Camry", 2017, 19000, 70000);
        UsedCar car5 = new UsedCar("GMC", "Sierra", 2015, 24987, 65050);
        UsedCar car6 = new UsedCar("Toyota", "Camry", 2010, 19000, 200000);
        Console.WriteLine("Welcome to the Car application.");
        List<Car> carInventory = new List<Car>(){Car1, Car2,Car3, car4, car5, car6};

        int count = -1; 
        foreach (Car c in carInventory)
        {
            count++;
    Console.WriteLine($"{count} {c.ToString()}"); 
            
            
        }
        
        
        int UserInput = -1;
        while (true)
        {
            Console.WriteLine("What car would you like?");
            try
            {
                UserInput = int.Parse(Console.ReadLine());
                if (UserInput > 6 && UserInput < 0)
                {
                    Console.WriteLine("Number can't be above 6.");
                    continue;
                }
                break;
            }
            catch
            {
                Console.WriteLine("Invalid input, try again");
                continue;
            }
        }


