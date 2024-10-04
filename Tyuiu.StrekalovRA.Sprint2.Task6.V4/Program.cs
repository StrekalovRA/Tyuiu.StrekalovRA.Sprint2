using Tyuiu.StrekalovRA.Sprint2.Task6.V4.Lib;

namespace Tyuiu.StrekalovRA.Sprint2.Task6.V4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #2
                Тема: Получение результата из switch
                Задание #6
                Вариант #4
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Мастям игральных карт условно присвоены следующие порядковые номера:
                масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3, масти «червы» — 4.
                По заданному номеру масти m (1 <= m <= 4) определить название соответствующей масти.
             */

            int M;
            Console.WriteLine("M = ");
            M = Convert.ToInt32(Console.ReadLine());

            DataService DS = new DataService();
            Console.WriteLine("РЕЗУЛЬТАТ: " + DS.FindCardSuit(M));
            Console.ReadKey();
        }
    }
}