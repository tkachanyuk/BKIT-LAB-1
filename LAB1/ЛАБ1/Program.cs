using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Program
    {
        static double ReadDouble(string message)
        {
            string resultString = "";
            double resultDouble = 0;
            bool flag = false;

            do
            {
                Console.Write(message);
                resultString = Console.ReadLine();
                flag = double.TryParse(resultString, out resultDouble);
                if (!flag) { Console.WriteLine("Необходимо ввести число."); }
            } while (!flag);
            return resultDouble;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Уравнение имеет вид А*х^2+B*x+C=0.");

            double A = 0, B = 0, C = 0, X1 = 0, X2 = 0;

            A = ReadDouble("Введите коэффициент А: ");
            Console.WriteLine("Вы ввели коэффициент А = " + A);

            B = ReadDouble("Введите коэффициент B: ");
            Console.WriteLine("Вы ввели коэффициент B = " + B);

            C = ReadDouble("Введите коэффициент C: ");
            Console.WriteLine("Вы ввели коэффициент C = " + C);
         

            if (A == 0 && B == 0 && C != 0)
                Console.WriteLine("Уравнение не имеет решений.");

            else if (A == 0 && B == 0 && C == 0)
                Console.WriteLine("Корней бесконечно много.");

            else if (A == 0 && B != 0 && C != 0)
            {
                X1 = -1 * B / C;
                Console.WriteLine("Единственный корень равен: " + X1);
            }

            else if ((B * B - 4 * A * C) > 0)

            {
                X1 = ((-1 * B + Math.Sqrt(C)) / (2 * A));
                Console.WriteLine("Первый корень равен: " + X1);
                X2 = ((-1 * B - Math.Sqrt(B * B - 4 * A * C)) / (2 * A));
                Console.WriteLine("Второй корень равен: " + X2);
            }

            else if ((B * B - 4 * A * C) == 0)

            {
                X1 = (-1 * B / (2 * A));
                Console.WriteLine("Единственный корень равен: " + X1);
            }


            else

            {
                Console.WriteLine("Дискриминант меньше 0, действительных корней нет.");
            }

            Console.ReadLine();
        }
    }
}
