using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHomework
{
    internal class moveZEROatFRONT
    {
        static void Main(string[] args)
        {

            //direct put the value
            int[] arr = new int[8] { 2, 4, 0, 1, 6, 0, 7, 2 };

            ////user accept array value
            //int num = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[num];
            //for (int i = 0; i < num; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            int cnt = arr.Length - 1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] != 0)
                {  
                    arr[cnt] = arr[i];
                    cnt--;
                }
            }

            while (cnt >= 0)
            {
                arr[cnt] = 0;
                cnt--;
            }
            foreach (int r in arr)
            {
                Console.WriteLine(r);
            }
        }
    }
}