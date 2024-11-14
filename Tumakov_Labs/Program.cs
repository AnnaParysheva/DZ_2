using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Labs
{
    //Виды банковского счета
    enum Bank_schet
    {
        Current,
        Saving
    }
    //информация о банковском счете
    struct Banks_Schet
    {
        /// <summary>
        /// Номер счета
        /// </summary>
        public int Number;
        /// <summary>
        /// Тип счета
        /// </summary>
        public string Type;
        /// <summary>
        /// Баланс
        /// </summary>
        public double Balance;
    }
    //ВУЗы
    enum VUZ
    {
        КГУ,
        КАИ,
        КХТИ
    }
    struct Worker
    {
        /// <summary>
        /// Имя работника
        /// </summary>
        public string Name;
        /// <summary>
        /// ВУЗ
        /// </summary>
        public VUZ Vuz;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Упражнение 3.1 Создать перечислимый тип данных отображающий виды банковского счета(текущий и сберегательный).Создать переменную типа перечисления, присвоить ей значение и вывести это значение на печать.
            Console.WriteLine("Упражнение 3.1 Создать перечислимый тип данных отображающий виды банковского счета(текущий и сберегательный).");
            Bank_schet bank = Bank_schet.Current;
            Console.WriteLine($"Тип банковского счета: {bank}");
            //Упражнение 3.2 Создать структуру данных, которая хранит информацию о банковском счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру значениями и напечатать результат.
            Console.WriteLine("Упражнение 3.2 Создать структуру данных, которая хранит информацию о банковском счете – его номер, тип и баланс.");
            Banks_Schet bank_account = new Banks_Schet();
            bank_account.Number = 123456789;
            bank_account.Type = "текущий";
            bank_account.Balance = 100000;
            Console.WriteLine($"Номер счета: {bank_account.Number}, Тип счета: {bank_account.Type}, Баланс: {bank_account.Balance}");
            //Домашнее задание 3.1 Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать структуру работник с двумя полями: имя, ВУЗ.Заполнить структуру данными и распечатать.
            Console.WriteLine("Домашнее задание 3.1 Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать структуру работник с двумя полями: имя, ВУЗ.");
            Worker worker = new Worker();
            worker.Name = "Анна";
            worker.Vuz = VUZ.КГУ;
            Console.WriteLine($"Имя работника: {worker.Name}, ВУЗ: {worker.Vuz}");
            Console.ReadKey();
        }
    }
}
