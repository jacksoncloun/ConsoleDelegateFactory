using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static int count;
        static void Main(string[] args)
        {
            char[] str = { 'a', 'b', 'c','a','e' };
            full_permutation(str, 0, str.Length - 1);
            Console.WriteLine(count);
            Console.ReadLine();
        }

        public static void full_permutation(char[] str, int begin, int end)
        {
            if (begin == end)
            {
                count++;//此处可以输出字符串或者记录字符串
                Console.WriteLine(str);
                return;
            }
            else
            {
                int i;
                for (i = begin; i <= end; i++)
                {
                    if (is_swap(str, begin, i))
                    {
                        swap(str, begin, i);
                        full_permutation(str, begin + 1, end);
                        swap(str, begin, i);
                    }
                }
            }
        }

        static void swap(char[] str, int a, int b)
        {
            char tmp = str[a];
            str[a] = str[b];
            str[b] = tmp;
        }


        static bool is_swap(char[] str, int begin, int k)
        {   //判断从子串的第一个字符串开始，直到k-1位置，看是否有重复的字符
            int i, flag;

            for (i = begin, flag = 1; i < k; i++)
            {
                if (str[i] == str[k])
                {
                    flag = 0;
                    break;
                }
            }

            return flag == 1 ? true : false;
        }



    }
}
