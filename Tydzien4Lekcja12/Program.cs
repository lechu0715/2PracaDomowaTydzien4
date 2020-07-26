using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydzien4Lekcja12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FizzBuzz fizzBuzz = new FizzBuzz();

                Console.WriteLine("Podaj liczbę całkowitą:");
                var number = int.Parse(Console.ReadLine());
                var score = fizzBuzz.Game(number);
                Console.WriteLine(score);
            }
            catch (Exception ex)
            {
                throw ex;

                Console.WriteLine("Podana wartość nie jest liczbą całkowitą");
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
