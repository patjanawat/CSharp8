using customer_relationship;

SampleCustomer c = new SampleCustomer("customer one", new DateTime(2010, 5, 31))
{
    Reminders =
    {
        { new DateTime(2010, 08, 12), "childs's birthday" },
        { new DateTime(1012, 11, 15), "anniversary" }
    }
};

SampleOrder o = new SampleOrder(new DateTime(2012, 6, 1), 5m);
c.AddOrder(o);

o = new SampleOrder(new DateTime(2103, 7, 4), 25m);
c.AddOrder(o);

ICustomer theCustomer = c;
Console.WriteLine($"Current discount: {theCustomer.ComputeLoyaltyDiscount()}");

//Switch expressions
//Example 1
var operation = 2;
var result = operation switch
{
    1 => "case 1",
    2 => "case 2",
    3 => "case 3",
    _ => "no case available"
};
Console.WriteLine(result);

//Example 2
var (a, b, option) = (10, 5, "+");
var exp1 = option switch
{
    "+" => a + b,
    "-" => a - b,
    "/" => a / b,
    _ => a * b
};
Console.WriteLine("Example 2={0}",exp1);

//Example 3
var value = 25;
int resultExp3 = value switch{
    _ when value > 10 => 0,
    _ when value < 10 => 1
};
Console.WriteLine("Example 3={0}",resultExp3);

var value4 = 25;
int resultExp4 = value switch{
    > 10 => 0,
    < 10 => 1
};
Console.WriteLine("Example 4={0}",resultExp4);

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

