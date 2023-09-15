using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Skriv in din beräkning med två tal som infattar en decimal");
            string helaberäkning = Console.ReadLine();

            int gångerindex = helaberäkning.IndexOf("*");

            string förstatalet = helaberäkning[..gångerindex];
            string andratalet = helaberäkning[(gångerindex + 1)..];

            double x = double.Parse(andratalet);
            double y = double.Parse(förstatalet);

            double sum = y * x;

            Console.WriteLine(sum);
            Console.ReadKey();
             

        
        
        }
      


    }



}