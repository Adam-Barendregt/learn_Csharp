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
