using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        /// <summary>
        ///  abc
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char[] arr = {'a', 'b', 'c', 'd', 'e'};
            int length = arr.Length - 1;
            bubbleSort(arr, 0, length);
            Permulation(arr, 0, length);
            Console.ReadLine();
        }


        static void Permulation(char[] arr, int k, int length)
        {
            int i;
            if (k == length)
            {
                for (i = 0; i < length; i++)
                    //printf("%c", arr[i]);
                    Console.Write(arr[i]);
                //printf("\n");
            }
            else
            {
                for (i = k; i < length; i++)
                {
                    if (k != i && arr[k] == arr[i])
                        continue;
                    swap(arr[k], arr[i]);//将arr中第i为的字符与第k位的字符交换
                    bubbleSort(arr, k + 1, length);
                    /*每次在进行交换后，都把剩余的元素进行一次排列。比如字符串abc,在进行最后一次外层交换时变成 cba。
                     此时要进行一次排序，交换cab后，在进行排列。*/
                    Permulation(arr, k + 1, length);//递归求出后面的排列
                    bubbleSort(arr, k + 1, length); //还原成上面语句执行前的字符样子。例如abc--->经过一次外层交换为bac(当输出bac、bca)后----->然后将bca经过排序为bac----->进行下一次外层循环交换cab,继续递归完成。

                }
            }
        }

        static void bubbleSort(char[] str, int begin, int length)
        {
            int i, j;
            for (i = begin; i < length; i++)
            {
                for (j = i + 1; j < length; j++)
                {
                    if (str[i] > str[j])
                    {
                        swap(str[i], str[j]);
                    }
                }
            }
        }

        static void swap(char a, char b)
        {
            char c;
            c = b;
            c = a;
            a = c;
        }


    }
}
