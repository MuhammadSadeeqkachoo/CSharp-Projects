//for Loop

for (int i = 0; i < 20; i++)
{
    Console.WriteLine(i);
}



//Use the break keyword to break the iteration statement

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}


//Loop through each element of an array

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}


//Overcoming the limitation of the foreach statement using the for statement

for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);