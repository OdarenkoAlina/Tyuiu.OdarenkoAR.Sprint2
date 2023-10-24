using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.OdarenkoAR.Sprint2.Task5.V3.Lib
{
    public class DataService : ISprint2Task5V3
    {
        public string FindDayName(int k)
        {
            string res;
            switch(k)
            {
                case 1:
                    res = "Понедельник";
                    break;
                case 2:
                    res = "Вторник";
                    break;
                case 3:
                    res = "Среда";
                    break;
                case 4:
                    res = "Четверг";
                    break;
                case 5:
                    res = "Пятница";
                    break;
                case 6:
                    res = "Суббота";
                    break;
                case 7:
                    res = "Воскресенье";
                    break;
                default:
                    res = "Некорректный день недели";
                    break;
            }
            return res;
        }
    }
}
