using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    enum Week
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("упражнение 1"); 
            int[] sequence = new int[10];
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"введите {i + 1}-ое число последовательности: ");
                    sequence[i] = Convert.ToInt32(Console.ReadLine());
                }
                bool x = true;
                for (int i = 0; i < sequence.Length - 1; i++)
                {
                    if (sequence[i] >= sequence[i + 1])
                    {
                        Console.WriteLine($"возрастающая последовательность прерывается после {i + 1}-го элемента");
                        x = false;
                        break;
                    }
                }
                if (x)
                {
                    Console.WriteLine("последовательность является возрастающей");
                }
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("error");
            }
            catch
            {
                Console.WriteLine("error");
            }

            Console.WriteLine("упражнение 2");
            Console.Write("Введите число от 6 до 14: ");
            try
            {
                switch (Convert.ToByte(Console.ReadLine()))
                {
                    case 6: Console.WriteLine("шестёрка"); break;
                    case 7: Console.WriteLine("семёрка"); break;
                    case 8: Console.WriteLine("восьмёрка"); break;
                    case 9: Console.WriteLine("девятка"); break;
                    case 10: Console.WriteLine("десятка"); break;
                    case 11: Console.WriteLine("валет"); break;
                    case 12: Console.WriteLine("дама"); break;
                    case 13: Console.WriteLine("король"); break;
                    case 14: Console.WriteLine("туз"); break;
                    default: Console.WriteLine("error"); break;
                }
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("error");
            }
            catch
            {
                Console.WriteLine("error");
            }

            Console.WriteLine("упражнение 3");
            Console.WriteLine("введите данные");
            switch (Console.ReadLine().ToLower())
            {
                case "jabroni": Console.WriteLine("Patron Tequila"); break;
                case "school counselor": Console.WriteLine("Anything with Alcohol"); break;
                case "programmer": Console.WriteLine("Hipster Craft Beer"); break;
                case "bike gang member": Console.WriteLine("Moonshine"); break;
                case "politician": Console.WriteLine("Your tax dollars"); break;
                case "rapper": Console.WriteLine("Cristal"); break;
                default: Console.WriteLine("Beer"); break;
            }

            Console.WriteLine("Упражнение 4");
            Console.WriteLine("Введите число от одного до семи");
            try
            {
                if (byte.TryParse(Console.ReadLine(), out byte day))
                {
                    Console.WriteLine(Enum.GetName(typeof(Week), day));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            catch
            {
                Console.WriteLine("error");
            }

            Console.WriteLine("упражнение 5"); 
            byte count = 0;
            string[] market = new string[10];
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"введите {i + 1}-ый элемент: ");
                    market[i] = Console.ReadLine();
                }
                foreach (string i in market)
                {
                    if ((i.ToLower().Equals("hello kitty")) | (i.ToLower().Equals("barbie doll")))
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{count} кукол в сумке");
            }
            catch
            {
                Console.WriteLine("error");
            }
            Console.ReadKey();
        }
    }
}