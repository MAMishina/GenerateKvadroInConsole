using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Добрый день. Я генератор квардатных уравнений. Работаю только с целыми коэффициентами");
        Console.WriteLine("Введите нижнюю границу значений коэффициентов.");
        int down = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nВведите верхнюю границу значений коэффициентов.");
        int up = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("\nУравнения с каким количестовм решений Вы хотите получить?");
        int count = Convert.ToInt32(Console.ReadLine());
        if (count <0 || count >2)
        {
            Console.WriteLine("Так не бывает. Может быть 0-2 решений.");
        }
        else
        {
            for (int a = down; a <= up; a++)
            {
                for (int b = down; b <= up; b++)
                {
                    for (int c = down; c <= up; c++)
                    {
                        double d = b * b - 4 * a * c;
                        if (count == 0 && d < 0)
                        {
                            Console.WriteLine($"{a}*x^2 + {b}*x + {c} - уравнение не имеет корней, его дискриминант равен 0");
                        }
                        else if (count == 1 && d == 0)
                        {
                            Console.WriteLine($"{a}*x^2 + {b}*x + {c} - уравнение имеет один корень. Х = {-b/(2*a)}, его дискриминант равен {d}");
                        }
                        else if (count == 2 && d > 0)
                        {
                            double x1 = (- b - Math.Sqrt(d)) / (2 * a);
                            double x2 = (- b + Math.Sqrt(d)) / (2 * a);
                            Console.WriteLine($"{a}*x^2 + {b}*x + {c} - уравнение имеет два корня. Х1 = {x1}, X2 = {x2}, его дискриминант равен {d}");
                        }
                    }
                }
            }
        }

    }
}