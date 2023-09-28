using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("упражнение 4.1, упражнение 4.2, дз 4.1");
            Console.WriteLine("введите номер года");
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                if (year > 0)
                {
                    byte leap = 0;
                    if (((year % 4 == 0) & (year % 100 != 0)) | (year % 400 == 0))
                    {
                        Console.WriteLine("вы выбрали високосный год, введите число от 1 до 366");
                        leap++;
                    }
                    else
                    {
                        Console.WriteLine("вы выбрали не високосный год, введите число от 1 до 365");
                    }
                    if (int.TryParse(Console.ReadLine(), out int day))
                    {
                        if ((day >= 1) & (day <= 31))
                        {
                            Console.WriteLine($"Январь {day}");
                        }
                        else if ((day >= 32) & (day <= (59 + leap)))
                        {
                            Console.WriteLine($"Февраль {day - 31}");
                        }
                        else if ((day >= (60 + leap)) & (day <= (90 + leap)))
                        {
                            Console.WriteLine($"Март {day - (59 + leap)}");
                        }
                        else if ((day >= (91 + leap)) & (day <= (120 + leap)))
                        {
                            Console.WriteLine($"Апрель {day - (90 + leap)}");
                        }
                        else if ((day >= (121 + leap)) & (day <= (151 + leap)))
                        {
                            Console.WriteLine($"Май {day - (120 + leap)}");
                        }
                        else if ((day >= (152 + leap)) & (day <= (181 + leap)))
                        {
                            Console.WriteLine($"Июнь {day - (151 + leap)}");
                        }
                        else if ((day >= (182 + leap)) & (day <= (212 + leap)))
                        {
                            Console.WriteLine($"Июль {day - (181 + leap)}");
                        }
                        else if ((day >= (213 + leap)) & (day <= (243 + leap)))
                        {
                            Console.WriteLine($"Август {day - (212 + leap)}");
                        }
                        else if ((day >= (244 + leap)) & (day <= (273 + leap)))
                        {
                            Console.WriteLine($"Сентябрь {day - (243 + leap)}");
                        }
                        else if ((day >= (274 + leap)) & (day <= (304 + leap)))
                        {
                            Console.WriteLine($"Октябрь {day - (273 + leap)}");
                        }
                        else if ((day >= (305 + leap)) & (day <= (334 + leap)))
                        {
                            Console.WriteLine($"Ноябрь {day - (304 + leap)}");
                        }
                        else if ((day >= (335 + leap)) & (day <= (365 + leap)))
                        {
                            Console.WriteLine($"Декабрь {day - (334 + leap)}");
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.ReadKey();
        }
    }
}