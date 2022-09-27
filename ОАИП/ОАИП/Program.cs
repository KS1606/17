using System;

 class Program
{
     static void Main(string[] args)
    {
        for (int i = 1; i>-1; i++)
        {
            Console.WriteLine("1.Игра \"Угадай число\"");
            Console.WriteLine("2.Таблица умножения");
            Console.WriteLine("3.Вывод делителей числа");
            Console.WriteLine("4.Закрыть программу");

            Console.WriteLine("Ведите номер программы которое хотите запустить ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                static int KS()
                {
                    Random rnd = new Random();
                    int v = rnd.Next(100);
                    return v;
                }


                int a = 0;
                int b = KS();
                Console.Write("Угадайте число от 1 до 100");
                for (int p = 1; p > -1 ; p++)
                {
                    Console.Write($" Попытка {p}: ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    a = c;
                    if (a <= 100)
                    {
                        if (a == b)
                        {
                            Console.WriteLine("Поздравляю вы угадали число! ");
                            break;
                        }

                        if (a < b)
                        {
                            Console.WriteLine("Нужно больше");
                        }

                        if (a > b)
                        {
                            Console.WriteLine("Нужно меньше");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Нужно ввести число от 1 до 100");
                    }

                }

            }

            if (num == 2)
            {


                int[,] a = new int[10, 10];

                for (int m = 1; m < 10; m++)
                {
                    for (int n = 1; n < 10; n++)
                    {
                        Console.Write(a[m, n] + m * n + "\t");
                    }

                    Console.WriteLine();
                }


            }
            if (num == 3)
            {
                static int DS()
                {
                    Console.WriteLine("Ведите число у которого хотите узнать делители");
                    int r = Convert.ToInt32(Console.ReadLine());
                    return r;
                }

                int y = DS();
                for (int u = 1; u * u <= y; u++)
                {
                    if (y % u == 0)
                        Console.Write(" " + u + " ");
                }
                Console.Write(" " + y + " ");
                Console.WriteLine();
            }
            if (num == 4)
            {
                break;
            }
        }
     }
 }   

             





