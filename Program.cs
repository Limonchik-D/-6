using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Используя двузначное случайное число, вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции.
            /*
            Random rnd = new Random();
            int ttt = rnd.Next(10, 99);
            Console.WriteLine($"Случаййное число = {ttt}");
            Console.ReadLine();

            //Задача 2. Дано целое число n, указывающее номер дня недели от 1 до 7. По указанному номеру n вывести название соответствующего дня недели.

            try
            {
               Console.WriteLine("Введите чесло от 1 до 7");
               int c = int.Parse(Console.ReadLine());

                switch (c)
            {
            case 1:
                Console.WriteLine("Понедельник");
                break;
            case 2:
                Console.WriteLine("Вторник");
                break;
            case 3:
                Console.WriteLine("Среда");
                break;
            case 4:
                Console.WriteLine("Четверг");
                break;
            case 5:
                Console.WriteLine("Пятница");
                break;
            case 6:
                Console.WriteLine("Суббота");
                break;
            case 7:
                Console.WriteLine("Воскресенье");
                break;
            default:
                Console.WriteLine("Нет такого дня недели");
                break;
                }
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Возникло исключение{ex.Message}");

                }
                Console.ReadLine();

                //Задача 3. Используя случайное число в диапазоне от 1 до 7, вывести на экран название дня недели.

                int c = int.Parse(Console.ReadLine());
                Random rnd = new Random();
                int ttt = rnd.Next(1, 7);
                Console.WriteLine($"Случаййное число = {ttt}");
                try
                {

                switch (c)
                {
            case 1:
                Console.WriteLine("Понедельник");
                break;
            case 2:
                Console.WriteLine("Вторник");
                break;
            case 3:
                Console.WriteLine("Среда");
                break;
            case 4:
                Console.WriteLine("Четверг");
                break;
            case 5:
                Console.WriteLine("Пятница");
                break;
            case 6:
                Console.WriteLine("Суббота");
                break;
            case 7:
                Console.WriteLine("Воскресенье");
                break;
            default:
                Console.WriteLine("Нет такого дня недели");
                break;
                    }
                }
                   catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Возникло исключение{ex.Message}");

                }
                    Console.ReadLine();

                //Задача 4. По номеру месяца вывести название времени года.

                Console.WriteLine("Какое время года");
                int c = int.Parse(Console.ReadLine());
                try
                {

                switch (c)
                {
            case 1:
                Console.WriteLine("Весна");
                break;
            case 2:
                Console.WriteLine("Лето");
                break;
            case 3:
                Console.WriteLine("Осень");
                break;
            case 4:
                Console.WriteLine("Зима");
            */
            //Задача 5.Дан признак транспортного средства: a – автомобиль, в – велосипед, м - мотоцикл, с – самолет, п – поезд.Вывести на экран максимальную скорость транспортного средства в зависимости от введенного признака.
            /*Console.WriteLine("Введите признак транспортного средства (a - автомобиль, в - велосипед, м - мотоцикл, с - самолет, п - поезд):");
            char transportType = Console.ReadKey().KeyChar;
            string c = (Console.ReadLine());

            switch (transportType)
            {
                case 'а':
                    Console.WriteLine("Максимальная скорость автомобиля: 200 км/ч");
                    break;
                case 'в':
                    Console.WriteLine("Максимальная скорость велосипеда: 25 км/ч");
                    break;
                case 'ь':
                    Console.WriteLine("Максимальная скорость мотоцикла: 180 км/ч");
                    break;
                case 'с':
                    Console.WriteLine("Максимальная скорость самолета: 900 км/ч");
                    break;
                case 'п':
                    Console.WriteLine("Максимальная скорость поезда: 300 км/ч");
                    break;
                default:
                    Console.WriteLine("Некорректный признак транспортного средства.");
                    break; 
                }*/
            //Задача 6. Вывести название предмета по введенной первой букве: ф – физика, м – математика, и – история, г – география, б – биология.
            /*Console.WriteLine("Ведите название предмета по введенной первой букве: ф – физика, м – математика, и – история, г – география, б – биология.");
            char bykva = Console.ReadKey().KeyChar;
            string c = Console.ReadLine();

            switch (bykva)
            {
                case 'ф':
                    Console.WriteLine("Физика");
                    break;
                case 'м':
                    Console.WriteLine("Математика");
                    break;
                case 'и':
                    Console.WriteLine("История");
                    break;
                case 'г':
                    Console.WriteLine("География");
                    break;
                case 'б':
                    Console.WriteLine("Биология");
                    break;
                default:
                    Console.WriteLine("Нет такого предмета");
                    break;
            }*/
        }
    }
}
