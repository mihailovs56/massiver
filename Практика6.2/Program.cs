using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Практика6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[x];
            int b = -1;
            int c = 1;
            
            for(int i = x; i > 0; i--)
            {
                b += i * c;
                c = -c;
                Console.WriteLine(b.ToString());
                mas[b] = b;
            }
            
            Console.WriteLine(string.Join(",", mas));
        }
    }
}
