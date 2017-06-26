using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            Console.WriteLine("Enter Length");

            float Length = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Width");
            float Width = float.Parse(Console.ReadLine());
            Console.WriteLine("Area " + (Length * Width));

            Console.WriteLine("Perimeter " + (2 * Length + 2 * Width));

            Console.WriteLine("Continue");
            



        }
    }
}
