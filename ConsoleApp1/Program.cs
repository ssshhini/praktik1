using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №1");
            while (true)
            {
                Console.Clear();
                Console.Write("Выберите задания: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №1");

                            double R, t, l;

                            Console.Write("Введите значение - t: ");
                            t = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - l: ");
                            l = Convert.ToDouble(Console.ReadLine());

                            R = 3 * Math.Pow(t, 2) + 3 * Math.Pow(l, 5) + 4.9;

                            Console.WriteLine($"R = {R}");

                            Console.ReadKey();

                        }
                        break;

                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №2");

                            double K, p, y, e;

                            Console.Write("Введите значение - p: ");
                            p = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            K = Math.Log(Math.Pow(p, 2) + Math.Pow(y, 3)) + Math.Pow(e, p);


                            Console.WriteLine($"K = {K}");

                            Console.ReadKey();
                        }
                        break;

                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №3");


                            double G, n, y;

                            Console.Write("Введите значение - n: ");
                            n = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            G = n * (y + 3.5) + Math.Sqrt(y);

                            Console.WriteLine($"G = {G}");


                            Console.ReadKey();
                        }
                        break;

                    case "4":
                        {

                            Console.Clear();
                            Console.WriteLine("Задание №4");


                            double D, a, t;

                            Console.Write("Введите значение - a: ");
                            a = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - t: ");
                            t = Convert.ToDouble(Console.ReadLine());

                            D = 9.8 * Math.Pow(a, 2) + 5.52 * Math.Cos(Math.Pow(t, 5));

                            Console.WriteLine($"D = {D}");

                            Console.ReadKey();

                        }

                        break;

                    case "5":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №5");

                            double L, x;

                            Console.Write("Введите значение - x: ");
                            x = Convert.ToDouble(Console.ReadLine());

                            L = 1.51 * Math.Cos(Math.Pow(x, 2)) + 2 * Math.Pow(x, 3);

                            Console.WriteLine($"L = {L}");

                            Console.ReadKey();
                        }

                        break;

                    case "6":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №6");

                            double M, y, e, x;


                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());


                            Console.Write("Введите значение - x: ");
                            x = Convert.ToDouble(Console.ReadLine());

                            M = Math.Cos(2 * y) + 3.6 * Math.Pow(e, x);


                            Console.WriteLine($"M = {M}");

                            Console.ReadKey();
                        }
                        break;

                    case "7":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №7");

                            double N, m;

                            Console.Write("Введите значение - m: ");
                            m = Convert.ToDouble(Console.ReadLine());

                            N = Math.Pow(m, 2) + 2.8 * Math.Abs(m) + 0.55;


                            Console.WriteLine($"N = {N}");

                            Console.ReadKey();
                        }
                        break;

                    case "8":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №8");

                            double T, y;

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            T = Math.Sqrt(Math.Abs(6 * Math.Pow(y, 2) - 0.1 * y + 4));

                            Console.WriteLine($"T = {T}");

                            Console.ReadKey();
                        }
                        break;

                    case "9":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №9");

                            double V, y, x;


                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());


                            Console.Write("Введите значение - x: ");
                            x = Convert.ToDouble(Console.ReadLine());

                            V = Math.Log(y + 0.95) + Math.Sin(Math.Pow(x, 4));

                            Console.WriteLine($"V = {V}");

                            Console.ReadKey();
                        }
                        break;

                    case "10":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №10");

                            double U, e, x, k, y;

                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - x: ");
                            x = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - k: ");
                            k = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            U = Math.Pow(e, y) + 7.355 * Math.Pow(k, 2) * Math.Sin(Math.Pow(x, 2));

                            Console.WriteLine($"U = {U}");

                            Console.ReadKey();
                        }
                        break;

                    case "11":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №11");

                            double S, y, x;

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - x: ");
                            x = Convert.ToDouble(Console.ReadLine());

                            S = 9.756 * Math.Pow(y, 7) + 2 * Math.Tan(x);


                            Console.WriteLine($"S = {S}");

                            Console.ReadKey();
                        }
                        break;

                    case "12":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №12");

                            double K, t, x;


                            Console.Write("Введите значение - t: ");
                            t = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - x: ");
                            x = Convert.ToDouble(Console.ReadLine());

                            K = 7 * Math.Pow(t, 2) + 3 * Math.Sin(Math.Pow(x, 3)) + 9.2;

                            Console.WriteLine($"K = {K}");

                            Console.ReadKey();
                        }
                        break;

                    case "13":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №13");

                            double E, y;

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            E = Math.Sqrt(Math.Abs(3 * Math.Pow(y, 3) + 0.5 * y + 4));

                            Console.WriteLine($"E = {E}");

                            Console.ReadKey();
                        }
                        break;

                    case "14":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №14");

                            double R, y, e, x;


                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - x: ");
                            x = Convert.ToDouble(Console.ReadLine());

                            R = Math.Abs(Math.Sqrt(Math.Pow(Math.Sin(y), 2) + Math.Pow(e, x)));

                            Console.WriteLine($"R = {R}");

                            Console.ReadKey();
                        }
                        break;

                    case "15":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №15");

                            double H, y;

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            H = Math.Sin(Math.Pow(y, 2)) - 2.8 * y + Math.Sqrt(Math.Abs(y));

                            Console.WriteLine($"H = {H}");

                            Console.ReadKey();
                        }
                        break;

                    case "16":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №16");

                            double S, y;

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            S = Math.Sqrt(Math.Cos(4 * Math.Pow(y, 2))) + 7.151;

                            Console.WriteLine($"S = {S}");

                            Console.ReadKey();
                        }
                        break;

                    case "17":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №17");

                            double N, y;

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            N = 3 * Math.Pow(y, 2) + Math.Sqrt(y + 1);

                            Console.WriteLine($"N = {N}");

                            Console.ReadKey();
                        }
                        break;

                    case "18":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №18");

                            double N, y;

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            N = 3 * Math.Pow(y, 2) + Math.Sqrt(Math.Pow(y, 3) + 1);

                            Console.WriteLine($"N = {N}");

                            Console.ReadKey();
                        }
                        break;

                    case "19":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №19");

                            double P, n, y, g;

                            Console.Write("Введите значение - n: ");
                            n = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - g: ");
                            g = Convert.ToDouble(Console.ReadLine());

                            P = n * Math.Sqrt(Math.Pow(y, 3) + 1.09 * g);


                            Console.WriteLine($"P = {P}");

                            Console.ReadKey();
                        }
                        break;

                    case "20":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №20");

                            double U, e, k, y, x;

                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - k: ");
                            k = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - x: ");
                            x = Convert.ToDouble(Console.ReadLine());

                            U = Math.Pow(e, (k + y)) + Math.Tan(x * Math.Sqrt(y));

                            Console.WriteLine($"U = {U}");

                            Console.ReadKey();
                        }
                        break;

                    case "21":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №21");

                            double P, e, y, h;


                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - h: ");
                            h = Convert.ToDouble(Console.ReadLine());

                            P = Math.Pow(e, (y + 5.5)) + 9.1 * Math.Pow(h, 3);

                            Console.WriteLine($"P = {P}");

                            Console.ReadKey();
                        }
                        break;

                    case "22":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №22");

                            double T, u, y, x;

                            Console.Write("Введите значение - u: ");
                            u = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - x: ");
                            x = Convert.ToDouble(Console.ReadLine());


                            T = Math.Sin(2 * u) * Math.Log(2 * Math.Pow(y, 2) + Math.Sqrt(x));

                            Console.WriteLine($"T = {T}");

                            Console.ReadKey();
                        }
                        break;

                    case "23":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №23");

                            double G, e, f, y;

                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - f: ");
                            f = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            G = Math.Pow(e, 2 * y) + Math.Sin(f);

                            Console.WriteLine($"G = {G}");

                            Console.ReadKey();
                        }
                        break;

                    case "24":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №24");

                            double F, y;

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            F = 2 * Math.Sin(0.214 * Math.Pow(y, 5)) + 1;

                            Console.WriteLine($"F = {F}");

                            Console.ReadKey();
                        }
                        break;

                    case "25":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №25");

                            double G, e, y, f;

                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - f: ");
                            f = Convert.ToDouble(Console.ReadLine());

                            G = e * Math.Pow(2, y) + Math.Sin(Math.Pow(f, 2));

                            Console.WriteLine($"G = {G}");

                            Console.ReadKey();
                        }
                        break;

                    case "26":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №26");

                            double Z, p;

                            Console.Write("Введите значение - p: ");
                            p = Convert.ToDouble(Console.ReadLine());

                            Z = Math.Pow(Math.Sin(Math.Pow(p, 2) + 0.4), 3);

                            Console.WriteLine($"Z = {Z}");

                            Console.ReadKey();
                        }
                        break;

                    case "27":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №27");

                            double W, v, e, y, x;

                            Console.Write("Введите значение - v: ");
                            v = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - x: ");
                            x = Convert.ToDouble(Console.ReadLine());

                            W = 1.03 * v + Math.Pow(e, 2 * y) + Math.Tan(Math.Abs(x));

                            Console.WriteLine($"W = {W}");

                            Console.ReadKey();
                        }
                        break;

                    case "28":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №28");

                            double T, e, y, h;

                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - h: ");
                            h = Convert.ToDouble(Console.ReadLine());

                            T = Math.Pow(e, y + h) + Math.Sqrt(Math.Abs(y * 6.4));

                            Console.WriteLine($"T = {T}");



                            Console.ReadKey();
                        }
                        break;

                    case "29":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №29");

                            double N, y;

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            N = 3 * Math.Pow(y, 2) + Math.Sqrt(Math.Abs(y + 1));

                            Console.WriteLine($"N = {N}");



                            Console.ReadKey();
                        }
                        break;

                    case "30":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №30");

                            double W, e, y, r;

                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - r: ");
                            r = Convert.ToDouble(Console.ReadLine());

                            W = Math.Pow(e, y + r) + 7.2 * Math.Sin(r);

                            Console.WriteLine($"W = {W}");

                            Console.ReadKey();
                        }
                        break;



                    default:
                        Console.WriteLine("Выберите корректное задание!");
                        Thread.Sleep(2000);
                        Console.WriteLine();
                        break;  
                }
            }
        }
    }
}
