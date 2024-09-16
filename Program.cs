using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace test_thing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            int amount_A = 1;
            int amount_space = 9;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < amount_space; j++)
                    Console.Write(" ");
                for (int k = 0; k < amount_A; k++)
                    Console.Write("A");
                Console.WriteLine();
                amount_A++;
                amount_space--;
            }
            Console.WriteLine("");



            //task 2
            
            double[]results = calculateMinMax(10);
            Console.WriteLine("min = " + results[0]);
            Console.WriteLine("max = " + results[1]);
            

            //task 3 
            days_of_the_week();
            

            int x = 9;
            int y = 5;
            Console.WriteLine((x--) + (--x));
            Console.WriteLine((y--) + (y--));




        }
        
        //task 2
        public static double[] calculateMinMax(int length)
        {
            double[] result = new double[2];
            double[] numbers = new double[length];
            for (int i = 0;i < length;i++)
            {   
                double input;
                do
                {
                    Console.WriteLine("Enter a decimal number between 10.0 and 100.0:");
                    input = Convert.ToDouble(Console.ReadLine());
                    if ((10 > input) || (input > 100))
                        Console.WriteLine("wrong value, please enter a correct value!!!");
                }
                while ((10 > input) || (input > 100));
                numbers[i] = input;
            }
            result[0] = numbers.Min();
            result[1] = numbers.Max();

            return result;
        }
        //task 3 
        public static void days_of_the_week()
        {
            bool loop =true;
            do
            {

                Console.WriteLine("enter an integer value between 1 to 7 (1 means Monday, 2 means Tuesday, … and 7 means Sunday) ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                        Console.WriteLine("weekday");

                        break;
                    case "6":
                    case "7":
                        Console.WriteLine("weekend");

                        break;
                    default:
                        Console.WriteLine("ERROR");

                        break;

                }
                Console.WriteLine("do you want to loop");
                if (Console.ReadLine() == "no")
                    loop = false;
            }
            while (loop);
            
            
        }


    }
}
