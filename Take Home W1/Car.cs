public class Car
{
    private string Make;
    private string Model;
    private int Year;
    private double Price;
    private string Type;
    public string getMake()
    {
        return Make;
    }
    public void setMake (string make)
    {
        Make = make;
    }

    public string getModel()
    {
        return Model;
    }
    public void setModel (string model)
    {
        Model = model;
    }

    public int getYear()
    {
        return Year;
    }
    public void setYear(int year)
    {
        Year = year;
    }

    public double getPrice()
    {
        return Price;
    }
    public void setPrice(double price)
    {
        Price = price;
    }

    public string getType()
    {
        return Type;
    }
    public void setType(string type)
    {
        Type = type;
    }

    public Car()
    {
    }

}

public class ElectricCar : Car
{
    private int BatteryCapacity;

    public int getBatteryCapacity()
    {
        return BatteryCapacity;
    }
    public void setBatteryCapacity(int batterycapacity)
    {
        BatteryCapacity = batterycapacity;
    }

    public ElectricCar(string _Make, string _Model, int _Year, double _Price, string _Type, int _BatteryCapacity)
    {
        setMake(_Make);
        setModel(_Model);
        setYear(_Year);
        setPrice(_Price);
        setBatteryCapacity(_BatteryCapacity);
        setType("Electric");
    }
}

public class HybridCar : Car
{
    private int GasTankSize;
    private int BatteryCapacity;

    public int getGasTankSize()
    {
        return GasTankSize;
    }
    public void setGasTankSize(int gastanksize)
    {
        GasTankSize = gastanksize;
    }

    public int getBatteryCapacity()
    {
        return BatteryCapacity;
    }
    public void setBatteryCapacity(int batterycapacity)
    {
        BatteryCapacity = batterycapacity;
    }

    public HybridCar(string _Make, string _Model, int _Year, double _Price, string _Type, int _GasTankSize, int _BatteryCapacity)
    {
        setMake(_Make);
        setModel(_Model);
        setYear(_Year);
        setPrice(_Price);
        setGasTankSize(_GasTankSize);
        setBatteryCapacity(_BatteryCapacity);
        setType("Hybrid");
    }
}

public class GasolineCar : Car
{
    private int GasTankSize;
    public int getGasTankSize()
    {
        return GasTankSize;
    }
    public void setGasTankSize(int gastanksize)
    {
        GasTankSize = gastanksize;
    }

    public GasolineCar(string _Make, string _Model, int _Year, double _Price, string _Type, int _GasTankSize)
    {
        setMake(_Make);
        setModel(_Model);
        setYear(_Year);
        setPrice(_Price);
        setGasTankSize (_GasTankSize);
        setType("Gasoline");
    }
}

public class Dealership
{

    private List<Car> Cars = new List<Car>();
    private List<Sale> SoldCars = new List<Sale>();

    private string Name;
    private string Location;

    public List<Car> getCars()
    {
        return Cars;
    }
    public void setCars(List<Car> cars)
    {
        Cars = cars;
    }

    public List<Sale> getSoldCars()
    {
        return SoldCars;
    }
    public void setSoldCars(List<Sale> soldcars)
    {
        SoldCars = soldcars;
    }
    public string getName()
    {
        return Name;
    }
    public void setName(string name)
    {
        Name = name;
    }
    public string getLocation()
    {
        return Location;
    }
    public void setLocation(string location)
    {
        Location = location;
    }

    public void RemoveCar()
    {
        string carMake,  carModel;
        if (Cars.Count == 0)
        {
            Console.WriteLine("No car hasn't been added yet, please add the car first");
        }
        else
        {
            back:
            Console.WriteLine("REMOVE CAR");
            Console.Write("Input the car make you want to remove : ");
            string makebuang = Console.ReadLine();
            Console.Write("input the car model you want to remove : ");
            string modelbuang = Console.ReadLine();
            carMake = makebuang;
            carModel = modelbuang;
            bool ada = false;
            for (int i = 0; i < Cars.Count; i++)
            {
                if (Cars[i].getMake() == carMake && Cars[i].getModel() == carModel)
                {
                    ada = true;
                    Console.Clear();
                    Cars.Remove(Cars[i]);
                    Console.WriteLine(makebuang + " " + modelbuang + " car has been removed. Press any key to continue");
                }
            }
            if (ada == false)
            {
                Console.WriteLine(makebuang + " " + modelbuang + " not found, please input make and model correctly");
                Console.ReadKey();
                Console.Clear();
                goto back;
            }
        }
    }
    public void AddCar(Car car)
    {
        Cars.Add(car);
    }


    public void PrintCar()
    {
        for (int i = 0; i <= Cars.Count - 1; i++)
        {
            Console.WriteLine(i + 1 + ". Car make : " + Cars[i].getMake());
            Console.WriteLine("Car model : " + Cars[i].getModel());
            Console.WriteLine("Car year : " + Cars[i].getYear());
            Console.WriteLine("Car price : " + Cars[i].getPrice());
            Console.WriteLine("Car type : "+ Cars[i].getType());
            Console.WriteLine();
        }
    }


    public class Sale
    {
        private string CustomerName;
        private Car car;
        private double PricePaid;

        public string getCustomerName()
        {
            return CustomerName;
        }
        public void setCustomerName(string customername)
        {
            CustomerName = customername;
        }
        public Car getcar()
        {
            return car;
        }
        public void setcar(Car _car)
        {
            car = _car;
        }   
        public double getPricePaid()
        {
            return PricePaid;
        }
        public void setPricePaid(double pricepaid)
        {
            PricePaid = pricepaid;
        }
       
    }
    public void MakeSale(Sale sale)
    { 
        for (int i = 0; i < Cars.Count; i++)
        {
            if (Cars[i].getMake() == sale.getcar().getMake());
            {
                Cars.Remove(Cars[i]);
                SoldCars.Add(sale);

            }
        }
    }

    public void PrintSales()
    {
        for (int i = 0; i <= SoldCars.Count - 1; i++)
        {
            Console.WriteLine("SALE(s) DETAILS\n-------------------------------------");
            Console.WriteLine(i + 1 + ". Customer name : " + SoldCars[i].getCustomerName());
            Console.WriteLine("Car make : " + SoldCars[i].getcar().getMake());
            Console.WriteLine("Car model : " + SoldCars[i].getcar().getModel);
            Console.WriteLine("Car type : " + SoldCars[i].getcar().getType());
            Console.WriteLine("Car year : " + SoldCars[i].getcar().getYear());
            Console.WriteLine("Price paid : " + SoldCars[i].getPricePaid());
            Console.WriteLine();
        }
    }
}
