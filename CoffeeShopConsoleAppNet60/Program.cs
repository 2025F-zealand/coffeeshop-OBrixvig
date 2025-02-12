// See https://aka.ms/new-console-template for more information
using CoffeeShopConsoleAppNet60;

Console.WriteLine("Hello, World!");

List<Coffee> coffeeDrinks = new List<Coffee>()
{
    new Latte(),
    new Cortado(),
    new BlackCoffee()
};
Console.WriteLine("drinks i listen");
foreach (var item in coffeeDrinks)
{
    Console.WriteLine(item.GetType() + item.GetInfo());
}

List<IMilk> coffeeWithMilk = new List<IMilk>()
{
    new Latte(),
    new Cortado()
};

Console.WriteLine("Drinks med mælk");
foreach (var item in coffeeWithMilk)
{
    Console.WriteLine($"{item.GetType()} Indeholder {item.MlMilk()} ML. mælk");
}

OrderSystem cashRegister = new OrderSystem();

Order order1 = new Order {
    OrderId = 1, 
    Barista = "Kevin", 
    Customer = "Oliver", 
    TableId = "bord 2", 
    Coffees = new List<Coffee> 
        {
            new Latte(), 
            new Cortado(), 
            new Latte()
        } 
};

Order order2 = new Order
{
    OrderId = 2,
    Barista = "Kevin",
    Customer = "Jonas",
    TableId = "bord 1",
    Coffees = new List<Coffee> {
    new BlackCoffee()}
};

cashRegister.AddOrder(order1);
cashRegister.AddOrder(order2);

Console.WriteLine();

cashRegister.PrintOrders();

Console.WriteLine();
Console.WriteLine($"Total Omsætning: {cashRegister.TotalRevenue()},-");
Console.WriteLine($"Antal Ordre: {cashRegister.TotalOrders()}");
Console.WriteLine($"Antal Kaffe Solgt: {cashRegister.TotalCoffeesSold()}");
