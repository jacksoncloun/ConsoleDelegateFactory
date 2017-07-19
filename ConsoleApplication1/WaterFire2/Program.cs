using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterFire2
{
    /// <summary>
    /// 烧水器,烧开之后烧水器要响,显示屏要显示温度
    /// </summary>
    public class Program
    {
        public delegate void waterDelegate(string degreen);
        public static event waterDelegate _waterDelegatesecond;
        static void Main(string[] args)
        {
            WaterLoudly water = new WaterLoudly();
            ShowScreen screen = new ShowScreen();
            int degreen = 95;
            //water.WaterSpeakeLoudly(degreen.ToString());
            //screen.ShowInScreen(degreen.ToString());


            //Heater(degreen.ToString(), water.WaterSpeakeLoudly);
            //Heater(degreen.ToString(), screen.ShowInScreen);

            for (int i = 0; i < 100; i++)
            {
                if (i > 95)
                {
                    //HotHeater(i.ToString());
                    BoilWater(i.ToString());
                    break;
                }
                Console.WriteLine("当前水温{0}度", i.ToString());
            }

              
            Console.ReadKey();
        }

        public static void HotHeater(string degreen)
        {
            WaterLoudly water = new WaterLoudly();
            ShowScreen screen = new ShowScreen();
            DelegateManager dm = new DelegateManager();
            dm._waterDelegate += water.WaterSpeakeLoudly;
            dm._waterDelegate += screen.ShowInScreen;
            dm.Heater(degreen.ToString());
        }


        public static void BoilWater(string degreen)
        {
            WaterLoudly water = new WaterLoudly();
            ShowScreen screen = new ShowScreen();
            _waterDelegatesecond += water.WaterSpeakeLoudly;
            _waterDelegatesecond += screen.ShowInScreen;
            _waterDelegatesecond(degreen);
        }

        public static void regist(string degreen)
        {
            if (_waterDelegatesecond != null)
            {
                _waterDelegatesecond(degreen);
            }
        }

        public static void Heater(string name, waterDelegate _waterDelegate)
        {
            _waterDelegate(name);
        }

    }
}
