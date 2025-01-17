﻿/*
string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result);
*/

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] message = orderStream.Split(',');

Array.Sort(message);

foreach (string str in message)
{
    char[] letter = str.ToCharArray();
    if(letter.Length != 4){
        Console.WriteLine($"{str}\t\t - Error");
    }
    else{Console.WriteLine($"{str}");}
    

}
