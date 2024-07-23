
string []  fraudulentOrderID = { "B123", "C234", "A345","C15","B177","G3003","C235","B179"};

foreach (string fra in fraudulentOrderID) {

    if (fra.StartsWith("B"))
{
    Console.WriteLine($"The name starts with {fra}");
}
}

