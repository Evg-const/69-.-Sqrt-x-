using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69.Sqrt__x_
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToString(MySqrtNewton(input)));
            Console.WriteLine(Convert.ToString(MySqrt(input)));

            Console.Read();
            
            
            int MySqrt(int x)
            {

                int left = 0, right = x, mid;
                bool flag;
                
                while (left <= right)
                {
                    mid = (right + left) / 2;

                    try
                    {
                        checked
                        {
                            flag = mid * mid < x;
                            if (mid * mid == x)
                            {
                                return mid;
                            }
                        }
                    }
                    catch (OverflowException)
                    {
                       flag = false;
                    }

                    if (flag)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                return right;
            }

            int MySqrtNewton(int x)
            {
                if (x == 0) return 0;
                double approx = 0.5 * x;
                double betterapprox = 0.0;
                while (true)
                {
                    betterapprox = 0.5 * (approx + x / approx);
                    if (approx - betterapprox < 1)
                    {
                        break;
                    }
                    approx = betterapprox;
                }
                return (int)betterapprox;
            }
        }
    }
}
