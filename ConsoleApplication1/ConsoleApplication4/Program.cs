using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Program
    {
        /// <summary>
        /// test delegate say hello in diff country  说不同的语言使用委托进行测试
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //ChineseSay("Tomas");
            //USASay("Tomas");
            //FranceSay("Tomas");

            //Say(SayType.中文, "Tomas");
            //Say(SayType.英语, "Tomas");
            //Say(SayType.法语,"Tomas");

            //Say3("Tomas", ChineseSay);
            //Say3("Tomas", USASay);
            //Say3("Tomas", FranceSay);

            //getLangeauge getLangeauge1, getLangeauge2, getLangeauge3;
            //getLangeauge1 = ChineseSay;
            //getLangeauge2 = USASay;
            //getLangeauge3 = FranceSay;
            //Say3("Tomas", getLangeauge1);
            //Say3("Tomas", getLangeauge2);
            //Say3("Tomas", getLangeauge3);

            //getLangeauge getLangeauge4;
            //getLangeauge4 = ChineseSay;
            //getLangeauge4 += USASay;
            //getLangeauge4 += FranceSay;
            //Say3("Tomas", getLangeauge4);

            //getLangeauge getLangeauge5=new getLangeauge(ChineseSay);
            //getLangeauge5 += USASay;
            //getLangeauge5("Tomas");


            //1.0
            //DelegateManager dm = new DelegateManager();
            //dm._DelegateManager(SayNames.Tomas.ToString(), ChineseSay);

            //2.0 in DelegateManager Class
            //DelegateManager dm1 = new DelegateManager();
            //dm1._getLangeauge = ChineseSay;
            //dm1._getLangeauge += USASay;
            //dm1._DelegateManager(SayNames.Tomas.ToString());

            //2.0.1
            //Tmp tmp = new Tmp();
            //tmp._getLangeauge = ChineseSay;
            //tmp._getLangeauge += USASay;
            //tmp._getLangeauge += FranceSay;
            //tmp.saywords(SayNames.Tomas.ToString());

            //3.0
            DelegateManager dm2 = new DelegateManager();
            //dm2._getLangeauge = ChineseSay;//出错：dm2._getLangeauge只能出现在+=【注册方法】或者-=【注销方法】的左边,因为委托使用了event那么在初始化的时候默认是Private
            dm2._getLangeauge += USASay;
            dm2._DelegateManager(SayNames.Tomas.ToString());
            Console.ReadKey();
        }


        #region Function1
        public static void ChineseSay(string name)
        {
            Console.WriteLine("中文： 你好 " + name);
        }
        public static void USASay(string name)
        {
            Console.WriteLine("英文：  Hello " + name);
        }
        public static void FranceSay(string name)
        {
            Console.WriteLine("法语：  France Bonur " + name);
        }
        #endregion

        #region Function2
        static void Say(SayType SayType, string name)
        {
            switch (SayType)
            {
                case SayType.中文:
                    ChineseSay(name);
                    break;
                case SayType.英语:
                    USASay(name);
                    break;
                case SayType.法语:
                    FranceSay(name);
                    break;
                default:
                    ChineseSay(name);
                    break;
            }
        }
        #endregion

        #region Function3
        public delegate void getLangeauge(string name);
        static void Say3(string name, getLangeauge _getLangeauge)
        {
            _getLangeauge(name);
        }
        #endregion

        #region Function4
        public static void Say4(string name)
        {

        }
        #endregion
    }

    /// <summary>
    /// 2.0.1
    /// </summary>
    public class Tmp
    {
        public ConsoleApplication4.Program.getLangeauge _getLangeauge;
        public void saywords(string name)
        {
            if (_getLangeauge != null)
            {
                _getLangeauge(name);
            }
        }
    }



    public enum SayType
    {
        中文 = 0,
        英语 = 1,
        法语 = 2
    }
    public enum SayNames
    {
        Tomas,
        Lucas,
        Lili
    }


}
