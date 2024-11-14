
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Files_Labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Выведите на экран информацию о каждом типе данных в виде: Тип данных – максимальное значение – минимальное значение
            Console.WriteLine("1. Выведите на экран информацию о каждом типе данных");
            Console.WriteLine($"Тип данных byte: максимальное значение {byte.MaxValue} минимальное значение {byte.MinValue}");
            Console.WriteLine($"Тип данных sbyte: максимальное значение {sbyte.MaxValue} минимальное значение {sbyte.MinValue}");
            Console.WriteLine($"Тип данных short: максимальное значение {short.MaxValue} минимальное значение {short.MinValue}");
            Console.WriteLine($"Тип данных ushort: максимальное значение {ushort.MaxValue} минимальное значение {ushort.MinValue}");
            Console.WriteLine($"Тип данных int: максимальное значение {int.MaxValue} минимальное значение {int.MinValue}");
            Console.WriteLine($"Тип данных uint: максимальное значение {uint.MaxValue} минимальное значение {uint.MinValue}");
            Console.WriteLine($"Тип данных long: максимальное значение {long.MaxValue} минимальное значение {long.MinValue}");
            Console.WriteLine($"Тип данных ulong: максимальное значение {ulong.MaxValue} минимальное значение {ulong.MinValue}");
            Console.WriteLine($"Тип данных float: максимальное значение {float.MaxValue} минимальное значение {float.MinValue}");
            Console.WriteLine($"Тип данных double: максимальное значение {double.MaxValue} минимальное значение {double.MinValue}");
            Console.WriteLine($"Тип данных decimal: максимальное значение {decimal.MaxValue} минимальное значение {decimal.MinValue}");
            // 2.Напишите программу, в которой принимаются данные пользователя в виде имени, города, возраста и PIN-кода.Далее сохраните все значение в соответствующей переменной, а затем распечатайте всю информацию в правильном формате.
            Console.WriteLine("2.Напишите программу, в которой принимаются данные пользователя в виде имени, города, возраста и PIN-кода.Далее сохраните все значение в соответствующей переменной, а затем распечатайте всю информацию в правильном формате.");
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Из какого вы города?");
            string city = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите PIN-код:");
            int pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Имя: {name}\nГород: {city}\nВозраст: {age}\nPIN-код: {pin}");
            // 3.Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на строчные.
            Console.WriteLine("3.Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на строчные.");
            Console.WriteLine("Введите строку:");
            string stroka = Console.ReadLine();
            string result = "";
            for (int i = 0; i < stroka.Length; i++)
            {
                if (char.IsUpper(Convert.ToChar(stroka[i])))
                {
                    result += char.ToLower(stroka[i]);
                }
                else
                {
                    result += char.ToUpper(stroka[i]);
                }
            }
            Console.WriteLine(result);
            // 4. Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести на экран.
            Console.WriteLine("4. Необходимо найти количество вхождений и вывести на экран.");
            Console.WriteLine("Введите строку:");
            string strochka = Console.ReadLine();
            Console.WriteLine("Введите подстроку:");
            string podstroka = Console.ReadLine();
            int count = new Regex(podstroka).Matches(strochka).Count;
            Console.WriteLine(count);
            // 5. Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически покрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена(normPrice),скидка в Duty Free(salePrice) и стоимость отпуска(holidayPrice).Например, если бутылка обычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10 %, вы сэкономите 1 фунт стерлингов на каждой бутылке.Если ваш отпуск стоит 500 фунтов стерлингов, ответ, который вы должны вернуть, будет 500.Все входные данные будут целыми числами.Пожалуйста, верните целое число.Округлить в меньшую сторону.
            Console.WriteLine("5. Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически покрыла расходы на ваш отпуск.");
            Console.WriteLine("Введите стандартную цену бутылки:");
            double normPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скидку в Duty Free (в процентах):");
            double salePrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость отпуска:");
            double holidayPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(holidayPrice / (normPrice * (salePrice / 100)));
            /*6. Создать структуру студента. У студента есть Фамилия, Имя, его Идентификатор, Дата
            рождения, Категория алкоголизма (a – студент алкоголик, b – студент любитель
            выпить, но не алкоголик, c – студент пьет по праздникам, d – студент не пьет), также у
            студента есть Объем выпитой жидкости конкретного напитка. Создать 5 студентов с
            различными параметрами. Посчитать общий объем выпитого, общий объем алкоголя
            (процент спирта) и кто сколько процентов алкоголя и жидкости от общего количества
            выпил. Предполагается, что студент пьет один вид напитка. Напитки задать в виде
            структуры: наименование типа напитка и процент спирта.*/
            Console.ReadKey();
        }
    }
}
