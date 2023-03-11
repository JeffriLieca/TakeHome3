using System;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;

Dealership.Sale jual = new Dealership.Sale();
Dealership dealership = new Dealership();
Car car = new Car();

string make, model, type;
int year, batterycapacity, gastanksize;
double price;

make = "";
model = "";
price = 0;

Console.Write("Add dealership name : ");
string namadealer = Console.ReadLine();
Console.Write("Add dealership location : ");
string lokasidealer = Console.ReadLine();
Console.Clear();

dealership.setName(namadealer);
dealership.setLocation(lokasidealer);

kembali:
Console.WriteLine("DEALER " + namadealer + ", " + lokasidealer);
Console.WriteLine("-------------------------------------");
Console.WriteLine("1. Add car");
Console.WriteLine("2. Remove car");
Console.WriteLine("3. Show car list");
Console.WriteLine("4. Make Sale");
Console.WriteLine("5. Show Sale");
Console.WriteLine("6. Exit");
Console.Write("Select menu : ");
int select = Convert.ToInt16(Console.ReadLine());
Console.Clear();



if (select == 1)
{
    Console.WriteLine("1. Electric car");
    Console.WriteLine("2. Hybrid car");
    Console.WriteLine("3. Gasoline car");
    Console.Write("Select car : ");
    int carselect = Convert.ToInt16(Console.ReadLine());

    Console.Clear();

    Console.Write("Add car make : ");
    make = Console.ReadLine();
    Console.Write("Add car model : ");
    model = Console.ReadLine();
    Console.Write("Add car year : ");
    year = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input price : Rp ");
    price = Convert.ToDouble(Console.ReadLine());

    if (carselect == 1) 
    {
        Console.Write("Add battery capacity : ");
        batterycapacity = Convert.ToInt32(Console.ReadLine());
        type = "Electric";
        ElectricCar electric = new ElectricCar(make, model, year, price, type, batterycapacity);
        dealership.AddCar(electric);
        
    }
    if (carselect == 2)
    {
        Console.Write("Add battery capacity : ");
        batterycapacity = Convert.ToInt32(Console.ReadLine());
        Console.Write("Add gas tank size : ");
        gastanksize = Convert.ToInt32(Console.ReadLine());
        type = "Hybrid";
        HybridCar hybrid = new HybridCar(make, model, year, price, type, batterycapacity, gastanksize);
        dealership.AddCar(hybrid);
    }
    if (carselect == 3)
    {
        Console.Write("Add gas tank size : ");
        gastanksize = Convert.ToInt32(Console.ReadLine());
        type = "Gasoline";
        GasolineCar gasoline = new GasolineCar(make, model, year, price, type, gastanksize);
        dealership.AddCar(gasoline);
    }
    Console.Clear();
    goto kembali;
}

if (select == 2)
{
    dealership.RemoveCar();
    Console.ReadKey();
    Console.Clear();
    goto kembali;
    
}
if (select == 3)
{
    dealership.PrintCar();
    Console.WriteLine("Press any key to continue");
    Console.ReadKey();
    Console.Clear();
    goto kembali;
}
if (select == 4)
{
    kembali2:
    Console.Write("Enter customer name : ");
    string namacustomer = Console.ReadLine();
    Console.Write("Enter car make : ");
    string namamake = Console.ReadLine();
    Console.Write("Enter car model : ");
    string namamodel = Console.ReadLine();
    Console.Write("Enter price paid : Rp ");
    double harga = Convert.ToDouble(Console.ReadLine());
    if (harga < price)
    {
        Console.WriteLine("Your money isn't enough, please re-enter the price paid.");
        Console.ReadKey();
        goto kembali2;
    }
    else
    {
        jual.setCustomerName(namacustomer);
        jual.getcar().setMake(namamake);
        jual.getcar().setModel(namamodel);
        jual.setPricePaid(harga);
        Console.Write("TRANSACTION SUCCESS\n" + namacustomer + "pruchased " + namamake + " " + namamodel + "\nPrice : Rp " + price + "\nPrice paid : Rp " + harga + "\n Change : Rp " + (price - harga));
    }
}
if (select == 5)
{
    dealership.PrintSales();
    Console.WriteLine("Press any key to continue");
    Console.ReadKey();
    Console.Clear();
    goto kembali;
}
if (select == 6)
{
    System.Environment.Exit(0);
}