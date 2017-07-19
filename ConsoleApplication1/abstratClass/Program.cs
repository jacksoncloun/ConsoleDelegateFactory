using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstratClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Tomato tomato = new Tomato();
            tomato.basefunc();
            tomato.eattomato();
            Console.ReadKey();
        }
    }


    public abstract class Food
    {
        public string fname { get; set; }
        public string ftype { get; set; }
        public string color { get; set; }
        public void basefunc()
        {
            Console.WriteLine("食物“" + fname + "”最基本属性,类别是“" + ftype + "”,颜色是：“" + color + "”");
        }
    }
    public class Tomato : Food
    {
        public Tomato()
        {
            fname = "西红柿";
            ftype = "水果类可生吃";
            color = "红色";
            with = 10.12M;
            height = 6.32M;
            weight = "0.5kg";
            taste = "甜甜的,水很多,味道很好吃";
        }
        public decimal with { get; set; }
        public decimal height { get; set; }
        public decimal longs
        {
            get
            {
                return with;
            }
        }
        public string weight { get; set; }
        public string taste { get; set; }

        public void eattomato()
        {
            Console.WriteLine(fname + "是" + ftype + "颜色基本都是" + color + "," + weight + "," + taste);
        }
    }
}
