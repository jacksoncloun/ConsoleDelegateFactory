using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //string sr = "abc";
            char[] sr = { 'a', 'b', 'c' };
            sort(sr);
            Console.ReadLine();
            sort2(sr, 0, sr.Length - 1);
            Console.ReadLine();
        }


        static void sort2(char[] str, int s, int length)
        {
            if (s == length)
            {
                Console.WriteLine(str);
            }
            for (int i = s; i <= length; i++)
            {
                //change(str, s, i);
                sort2(str, s+1, length);
                //change(str, s, i);
            }
        }

        /// <summary>
        /// abc
        /// </summary>
        /// <param name="str"></param>
        static void sort(char[] str)
        {
            Console.WriteLine(str);      //abc
            if (str[1] != str[2])
            {
                change(str, 1, 2);
                Console.WriteLine(str);  //acb
            }

            if (str[0] != str[1])
            {
                change(str, 0, 1);
                Console.WriteLine(str);  //cab
                change(str, 1, 2);
                Console.WriteLine(str);  //cba
            }

            if (str[0] != str[1])
            {
                change(str, 0, 1);
                Console.WriteLine(str);  //bca
                change(str, 1, 2);
                Console.WriteLine(str);  //bac
            }
        }

        static void change(char[] str, int a, int b)
        {
            char c;
            c = str[a];
            str[a] = str[b];
            str[b] = c;
        }
    }
}
