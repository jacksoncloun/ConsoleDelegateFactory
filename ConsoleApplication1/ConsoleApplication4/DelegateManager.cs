using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class DelegateManager
    {
        /// <summary>
        /// 1.0
        /// </summary>
        //public ConsoleApplication4.Program.getLangeauge _getLangeauge;
        //public void _DelegateManager(string name,ConsoleApplication4.Program.getLangeauge saylanguage)
        //{
        //    saylanguage(name);
        //}


        /// <summary>
        /// 2.0
        /// </summary>
        //public ConsoleApplication4.program.getlangeauge _getlangeauge;
        //public void _delegatemanager(string name)
        //{
        //    if (_getlangeauge != null)
        //    {
        //        _getlangeauge(name);
        //    }
        //}

        /// <summary>
        /// 3.0   Event出场了，它封装了委托类型的变量，使得：在类【即委托类】的内部，不管你声明它是public还是protected，它总是private的。在类的外部，注册“+=”和注销“-=”的访问限定符与你在声明事件时使用的访问符相同。
        /// </summary>
        public event ConsoleApplication4.Program.getLangeauge _getLangeauge;
        public void _DelegateManager(string name)
        {
            if (_getLangeauge != null)
            {
                _getLangeauge(name);
            }
        }
    }
}
