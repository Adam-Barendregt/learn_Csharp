// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, David!");

string firstFriend = "Maria";
firstFriend = firstFriend.Trim();



string secondFriend = "Scott";

string friends = $"My friends are {firstFriend} and {secondFriend.Trim()}";

Console.WriteLine(friends);
friends = friends.Replace("Scott", "Damian");
Console.WriteLine(friends);

int a = 2100000000;
int b = 2100000000;
// to calculate the integers with long for longer than 32bit integers
long c = (long)a + (long)b;
Console.WriteLine(c);

decimal d = 42.1M;
decimal e = 38.2M;
decimal f = d + e;
Console.WriteLine($"The answer is {f}");

int g = 5;
int h = 3;
int i = 4;
if ((g + h + i > 10) && (g == h))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}