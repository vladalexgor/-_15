using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_15
{
    class Program
    {
        /*Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:
        - метод void setStart(int x) - устанавливает начальное значение
        - метод int getNext() - возвращает следующее число ряда
        - метод void reset() - выполняет сброс к начальному значению
        Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries.
        В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.*/
        static void Main(string[] args)
        {
            ArithProgression aP = new ArithProgression();
            //В скобках вводится начальное значение арифметической прогрессии с разностью "5". Выводится пять первых членов прогрессии.
            Console.WriteLine("Первые пять членов арифметической прогрессии:");
            aP.setStart(5);
            Console.WriteLine(aP.getNext());
            aP.reset();
            Console.WriteLine(aP.getNext());
            aP.reset();
            Console.WriteLine(aP.getNext());
            aP.reset();
            Console.WriteLine(aP.getNext());
            aP.reset();
            Console.WriteLine(aP.getNext());
            aP.reset();

            GeomProgression gP = new GeomProgression();
            //В скобках вводится начальное значение геометрической прогрессии со знаменателем "5". Выводится пять первых членов прогрессии.
            Console.WriteLine("Первые пять членов геометрической прогрессии:");
            gP.setStart(5);
            Console.WriteLine(gP.getNext());
            gP.reset();
            Console.WriteLine(gP.getNext());
            gP.reset();
            Console.WriteLine(gP.getNext());
            gP.reset();
            Console.WriteLine(gP.getNext());
            gP.reset();
            Console.WriteLine(gP.getNext());
            gP.reset();
            Console.WriteLine("Для завершения программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }

    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        int difference = 5;
        int a;
        int a1;
        int N = 1;
        public void setStart(int x)
        {
            a1 = a = x;
        }
        public int getNext()
        {
            a = a + difference * (N - 1);
            N++;
            return a;
        }
        public void reset()
        {
            a = a1;
        }
    }
    class GeomProgression : ISeries
    {
        int denominator = 5;
        double b;
        double b1;
        int N = 1;
        public void setStart(int x)
        {
            b1 = b = x;
        }
        public int getNext()
        {
            b = b * Math.Pow(denominator,(N - 1));
            N++;
            return (int)b;
        }
        public void reset()
        {
            b = b1;
        }
    }
}
