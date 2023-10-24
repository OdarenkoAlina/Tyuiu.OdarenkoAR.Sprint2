using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.OdarenkoAR.Sprint2.Task5.V3.Lib;
namespace Tyuiu.OdarenkoAR.Sprint2.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Одаренко А. Р. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнила Одаренко А. Р. | ИСПб-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет оператор switch, вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("* Условие: Составить программу, которая в зависимости от порядкового      *");
            Console.WriteLine("* номера дня недели (1, 2,..., 7) выводит на экран его название           *");
            Console.WriteLine("* (понедельник, вторник,..., воскресенье).                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите номер дня недели: ");
            int k = Convert.ToInt32(Console.ReadLine());
            string res;
            if ((k < 1)||(k > 7))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "День недели:" + ds.FindDayName(k);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
