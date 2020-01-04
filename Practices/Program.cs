using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int a;
                Console.WriteLine("Введите номер задачи для вывода (1 - 4), или 0 для закрытия программы: ");
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            Z1();
                            break;
                        case 2:
                            Z2();
                            break;
                        case 3:
                            Z3();
                            break;
                        case 4:
                            Z4();
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("Такого номера задачи нет");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка! Введите число, соответсувующее номеру задачи!");
                };
            }
        }

        public static void Z1()
        {
            Console.WriteLine("Задание 1. \nСоздайте программу, что будет запрашивать два числа у пользователя. Полученные данные поместите в переменные.Поменяйте местами значения в переменных.");
            int a, b, tmp;
            Console.Write("Введите число a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nВы ввели: a - {a}, b - {b}.");
            Console.WriteLine("Поменяем их местми:");
            tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine($"Теперь: a - {a}, b - {b}.");
        }

        public static void Z2()
        {
            Console.WriteLine("Задание 2. Напишите программу, которая будет получать от пользователя число с 4 числами. Реализуйте разделение этого числа на отдельные цифры. ");
            string a;
            a = Console.ReadLine();
            for(int i = 0; i < a.ToCharArray().Length; i++)
            {
                Console.WriteLine(a.ToCharArray()[i]);
            }
            //foreach(int i in a.ToCharArray())
            //{
            //    Console.WriteLine(i);
            //}
        }

        public static void Z3()
        {
            Console.WriteLine("Задание 3. Попросите пользователя ввести URL какого-либо сайта. После ввода данных выведите в консоль доменное имя полученного URL адреса.");
            //string str;
            Console.WriteLine("Введите URL сайта:");
            string str = Console.ReadLine();
            Console.WriteLine(str.Split('.')[1]); 
        }

        public static void Z4()
        {
            Console.WriteLine("Задание 4. Создайте программу «Депозитный калькулятор», которая будет рассчитывать ежегодную и итоговую сумму вклада с учетом процентной ставки банка.");
            int years = 0, percent = 0;
            float sum = 0, amount;
            Console.WriteLine("Введите данные, для рассчета суммы депозита. ");
            try
            {
                Console.Write("Сумма депозита, рублей: ");
                sum = Convert.ToSingle(Console.ReadLine());
                Console.Write("Срок вклада, лет: ");
                years = Convert.ToInt32(Console.ReadLine());
                Console.Write("Процент депозита: ");
                percent = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка! Вы ввели неправильные данные!");
            }

            amount = sum;
            for (int i = 0; i < years; i++)
            {
                amount += (amount / 100 * percent);
                Console.WriteLine($"За {i+1} год на депозите накопится {amount} руб. "); ;
            }
            
            Console.WriteLine($"Итого: {amount} рублей.");

        }
    }
}
