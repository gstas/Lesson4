using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            12.	Считая, что Земля — идеальная сфера с радиусом r ≈ 6350 км, 
            определить расстояние до линии горизонта от точки с высотой над Землей, 
            равной 1, 2, ..., 10 км.
            */
            int R = 6350;
            for (int h = 1; h <= 10; h++)
            {
                double q = R + h;
                double dist = Math.Round(Math.Sqrt(q * q - R * R), 3);
                Console.WriteLine($"Высота: {h}км, расстояние до горизонта: {dist}км");
            }

            Console.WriteLine();

            /*
            142. Выведите на экран все четырехразрядные числа, 
            в записи которых нет одинаковых цифр. 
            */
            for (int r1 = 1; r1 < 10; r1++)
            {
                for (int r2 = 0; r2 < 10; r2++)
                {
                    for (int r3 = 0; r3 < 10; r3++)
                    {
                        for (int r4 = 0; r4 < 10; r4++)
                        {
                            if (r1 != r2 && r1 != r3 && r1 != r4
                                && r2 != r3 && r2 != r4
                                && r3 != r4)
                            {
                                //Console.WriteLine("" + r1 + r2 + r3 + r4);
                            }

                        }
                    }
                }
            }

            /*
            321.	Составить программу для графического представления делимости 
            чисел от 1 до n (значение n вводится с клавиатуры). 
            В каждой строке надо напечатать очередное число и столько символов + (плюс), 
            сколько делителей у этого числа. Например, если n = 4, 
            то на экране должно быть напечатано:
            1+
            2++
            3++
            4+++

             */

            Console.Write("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());   
            for (int i = 1; i <= n; i++)
            {
                Console.Write(""+ i);
                for (int j = 1; j <= n; j++)
                {
                    if (i % j == 0)
                        Console.Write("+");
                }
                Console.WriteLine();
            }

        }
    }
}
