using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterFire2
{
    public class DelegateManager
    {
        public event WaterFire2.Program.waterDelegate _waterDelegate;
        public void Heater(string name)
        {
            if (_waterDelegate != null)
            {
                _waterDelegate(name);
            }
        }
    }
}
