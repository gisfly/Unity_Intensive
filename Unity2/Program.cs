using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание к уроку 2. Rock, Paper, Scissors");
            Console.WriteLine("Необходимо создать класс Player, в котором должны быть реализованы следующие моменты:");
            Console.WriteLine("1)перечисление для установки выбора: enum VARIANTS;");
            Console.WriteLine("2)переменные для установки имени, а также определенного варианта из перечисления;");
            Console.WriteLine("3)два конструктора.Первый ничего не принимает и устанавливает случайное значение из перечисления, а также имя «Bot». Второй конструктор принимает определенный вариант из перечисления и имя для объекта;");
            Console.WriteLine("4)функция whoWins, которая принимает два объекта и возвращает либо строку «Ничья», либо информацию про игрока, который победил.");
            Console.WriteLine("\nИгра: Камень,ножницы, бумага!");                            
            Player bot = new Player();
            Player alex = new Player(VARIANTS.PAPER, "Alex");

            Console.Write(bot.WhoWins(bot, alex));

            Console.ReadKey();
        }
    }
}
