//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace arrayhomework
//{
//    internal class movezeroatend
//    {
//        static void main(string[] args)
//        {
//            int[] arr = new int[8] { 2, 4, 0, 1, 6, 0, 7, 2 };
//            int cnt = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] != 0)
//                {
//                    arr[cnt] = arr[i];
//                    cnt++;
//                }
//            }

//            while (cnt < arr.Length)
//            {
//                arr[cnt] = 0;
//                cnt++;
//            }
//            foreach (int r in arr)
//            {
//                 Console.WriteLine(r);
//            }
//        }
//    }
//}
