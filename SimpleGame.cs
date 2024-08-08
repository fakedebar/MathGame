using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first Number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.Write("Enter Thes Second Number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);
            int answer = numberA * numberB;

            Console.Write("Value of " + numberA + " x " + numberB + ": ");
            string answerInput = Console.ReadLine();
            int actualAnswer = Convert.ToInt32(answerInput);
            if (answer == actualAnswer)
            {
            Console.WriteLine("Well Done ! ");
            Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Close but it was Wrong");
                Console.ReadLine();
                } 
            }
            }
        }
    
