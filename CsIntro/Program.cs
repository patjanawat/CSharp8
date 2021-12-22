using customer_relationship;
using Asynchronous_sample;
using AnimalNameGroup;

using VarPatternNamespace;
Console.WriteLine(VarPattern.Transform(new Point(1,2)));
Console.WriteLine(VarPattern.Transform(new Point(5,2)));
Console.WriteLine(VarPattern.Transform(new Point(5,5)));
/*
using   RelationPatternNamespace;
Console.WriteLine(RelationPattern.Classtify(99));
*/
/*
using TypePatternNamespace;

Truck big = new Truck();
Console.WriteLine(big.CalculateToll());
*/

//Declaretion and type patterns
/*Console.WriteLine("Declaretion and type patterns");
int? xNullable = 7;
int y = 23;
object yboxed = y;
if(xNullable is int a && yboxed is int b)
{
    Console.WriteLine(a + b);
}*/

//Record
/*Animal animal= new ("king","kong");
Console.WriteLine(@$"{animal.firstName} {animal.lastName} Family.");

Machine machine1 = new("Nancy","Davolio"){phoneNumbers = new string[1]};
Console.WriteLine(@$"{machine1.firstName} {machine1.lastName} {machine1.phoneNumbers}.");

Machine machine2 = machine1 with {firstName = "King"};
Console.WriteLine(@$"{machine2.firstName} {machine2.lastName} {machine2.phoneNumbers}.");

Machine machine3 = machine1 with {lastName = "ajai",phoneNumbers = new string[2]{"A","B"}};
Console.WriteLine(@$"{machine3.firstName} {machine3.lastName} {machine3.phoneNumbers}.");
*/
/*
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
Console.WriteLine("Example 2={0}", exp1);

//Example 3
var value = 25;
int resultExp3 = value switch
{
    _ when value > 10 => 0,
    _ when value < 10 => 1
};
Console.WriteLine("Example 3={0}", resultExp3);

var value4 = 25;
int resultExp4 = value switch
{
    > 10 => 0,
    < 10 => 1
};
Console.WriteLine("Example 4={0}", resultExp4);

//Static local function
Console.WriteLine("----------Static local function----------");
int M()
{
   int y = 5;
    LocalFunction();
    return y;

    void LocalFunction() => y = 6;    
};
Console.WriteLine("Local function {0}",M());
int N(){
    int y= 5;
    int x= 7;
    return Add(x,y);

    static int Add(int left, int right)=> left + right;
}
Console.WriteLine("Local function {0}",N());
//Aysnchronous sterams
var aResult = Asynchronous_sample1.GenerateSequence();
await foreach (var item in aResult)
{
    Console.WriteLine(item);
}

//Indices and ranges
string[] words = new string[]
{
                // index from start    index from end
    "The",      // 0                   ^9
    "quick",    // 1                   ^8
    "brown",    // 2                   ^7
    "fox",      // 3                   ^6
    "jumped",   // 4                   ^5
    "over",     // 5                   ^4
    "the",      // 6                   ^3
    "lazy",     // 7                   ^2
    "dog"       // 8                   ^1
};
var allWords = words[..];

//Null coalescing operator ??=
List<int> numbers = null;

(numbers??= new List<int>()).Add(5);
Console.WriteLine(string.Join(" ",numbers));

int? aka = null;
numbers.Add(aka ??= 0);
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine(a);



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/
