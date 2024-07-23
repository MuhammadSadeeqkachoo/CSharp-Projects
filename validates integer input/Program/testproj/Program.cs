
Console.WriteLine("Input a number between 5 and 10 :");
string? number;
int num;
bool isinteger = false;

while (true){

    number = Console.ReadLine();
    isinteger = int.TryParse(number, out num);

    if(num>10 || num < 5){
        Console.WriteLine("Enter value between 5 and 10 :");
    }
    else{break;}

}
Console.WriteLine("Your Input is accepted");