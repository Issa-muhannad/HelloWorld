// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

string firstFriend = "      maria      ";
string secondFriend = "       sage     ";

firstFriend = firstFriend.TrimStart(); //to remove space.


Console.WriteLine($"My Friends are {firstFriend} and {secondFriend.Trim()}");

// $ is called string interpolation. to concatenate a string with values of other strings, instead of using the + sign.
