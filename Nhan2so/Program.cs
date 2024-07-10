using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhan2so
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 5, 9, 1, 0, 3, 7, 8 };
            int max1 = arr[0], max2 = arr[0];
            int place = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max1 < arr[i])
                {
                    max1 = arr[i];
                    place = i;
                }

            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (max2 < arr[i] && place != i)
                {
                    max2 = arr[i];
                }

            }
            int sum = max1*max2;
            Console.WriteLine("So trong mang: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("Tich cua 2 so lon nhat la: " + sum);
            Console.ReadLine();
        }
    }
}
