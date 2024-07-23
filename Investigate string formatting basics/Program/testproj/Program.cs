string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);



Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");


decimal price = 123.45m;
decimal salePrice = 102.45m;

int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");//currency Representation

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");//Number Formatting

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

Console.WriteLine(yourDiscount);