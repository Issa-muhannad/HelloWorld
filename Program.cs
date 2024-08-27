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

/*int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c); // shortcut conso + tab, wl + tab

int y = 2100000000;
int z = 2100000000;
//long k = (long)y + (long)z;
long k = checked(y + z); // this way we ask the compiler to tell us if there is an overflow and give us an error. runtime exception.
//Unhandled exception. System.OverflowException: Arithmetic operation resulted in an overflow.
Console.WriteLine(k);*/

// order of operations

/*int a = 5;
int b = 4;
int c = 2;
//int d = a + b * c;
int d = (a + b) * c;
Console.WriteLine(d);*/

/*int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c; //integet division gives whole numbers
Console.WriteLine(d);*/

/*int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");*/

/*int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");*/

// double type

/*double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c;
Console.WriteLine(d);*/

/*double a = 19;
double b = 23;
double c = 8;
double d = (a + b) / c;
Console.WriteLine(d);

double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");

double third = 1.0 / 3.0;
Console.WriteLine(third);*/

// decimal types

/*decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);*/

/*double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine(area);*/