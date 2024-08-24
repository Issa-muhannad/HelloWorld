// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

/*Console.WriteLine("Hello, World!");

string firstFriend = "      maria      ";
string secondFriend = "       sage     ";

firstFriend = firstFriend.TrimStart(); //to remove space.


Console.WriteLine($"My Friends are {firstFriend} and {secondFriend.Trim()}");*/

// $ is called string interpolation. to concatenate a string with values of other strings, instead of using the + sign.

// replace

/*string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());*/

//search strings

/*string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("hello"));
Console.WriteLine(songLyrics.Contains("Hello"));
//upper case is different from lower case. 
Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.EndsWith("say"));*/




// Numbers, Integers and math

int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c); // shortcut conso + tab, wl + tab

int y = 2100000000;
int z = 2100000000;
//long k = (long)y + (long)z;
long k = checked(y + z); // this way we ask the compiler to tell us if there is an overflow and give us an error. runtime exception.
//Unhandled exception. System.OverflowException: Arithmetic operation resulted in an overflow.
Console.WriteLine(k);
