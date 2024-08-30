// See https://aka.ms/new-console-template for more information
using System.Globalization;

{
    Console.Write("Är det fint väder?");
string svar = Console.ReadLine();
if(svar == "j" || svar == "J")
    Console.WriteLine("Vi går på picknik");
    else if (svar == "n" || svar == "N")
    Console.WriteLine("Vi stannar inne och läser en bok");
    else
    Console.WriteLine("Jag förstår inte");
} 