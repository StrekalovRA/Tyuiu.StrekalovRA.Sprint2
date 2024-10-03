using Tyuiu.StrekalovRA.Sprint2.Task4.V8.Lib;

namespace Tyuiu.StrekalovRA.Sprint2.Task4.V8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #2
                Тема: Вложенные операторы if - else
                Задание #4
                Вариант #8
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Ввести x, y, получить Z:
                Z = (5+sqrt(y+5)/x³)^x если 2x > y + 15, иначе
                Z = 2x²+2x-(4+6/(y^2)).
             */

            double X, Y;
            Console.WriteLine("X = ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y = ");
            Y = Convert.ToInt32(Console.ReadLine());

            DataService DS = new DataService();
            Console.WriteLine("РЕЗУЛЬТАТ: " + DS.Calculate(X, Y));
            Console.ReadKey();
        }
    }
}