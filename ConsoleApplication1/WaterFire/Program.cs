using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterFire
{
    /// <summary>
    /// 烧水器,烧开之后烧水器要响,显示屏要显示温度
    /// </summary>
    public class Program
    {
        public delegate void Deletegate(string name);
        static void Main(string[] args)
        {
            //ShowFunc("90", SpeakeLoudly);
            //ShowFunc("90", ShowInScreen);


            DelegateManage dm = new DelegateManage();
            dm._delegate += SpeakeLoudly;
            dm._delegate += ShowInScreen;
            dm.eventHander("95");
            Console.ReadKey();
        }

        public static void ShowFunc(string name, Deletegate _Deletegate)
        {
            _Deletegate(name);
        }


        public static void SpeakeLoudly(string name)
        {
            Console.WriteLine("水壶响了,水开了,温度已经{0}度了", name);
        }
        public static void ShowInScreen(string name)
        {
            Console.WriteLine("显示屏亮了,显示当前温度{0}度", name);
        }
    }

    public class DelegateManage
    {
        public event WaterFire.Program.Deletegate _delegate;
        public void eventHander(string name)
        {
            if (_delegate != null)
            {
                _delegate(name);
            }
        }
    }

    public class Loudly
    {

    }
    public class ShowScreen
    {

    }
}
