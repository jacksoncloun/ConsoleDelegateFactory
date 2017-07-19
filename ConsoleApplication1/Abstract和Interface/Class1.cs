using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract和Interface
{
    /// <summary>
    /// 这里讲述抽象类和接口
    /// 一个普通类如果继承了接口，那么必须实现接口里面的所有方法的方法体
    /// 一个普通类如果派生自某个抽象类，那么抽象类里面的方法可以直接调用，而不用继承所有方法
    /// </summary>
    public class NomalClass : IClassInterface   //这个普通类继承了 IClassInterface  这个接口，那么必须要实现接口里面的所有的方法,否则编译是不通过的
    {
        public void method1()
        {
            Console.WriteLine("hello word");
        }
        public void method2() { Console.WriteLine("hello method2"); }
    }

    public interface IClassInterface
    {
        void method1();
        void method2();
        //void method3();
    }

    /// <summary>
    ///  只要是抽象属性，不管是抽象类还是抽象方法都要加上 abstract关键字，如果抽象类没有加，但是在抽象方法中加了，那么在编译的时候默认这个类就会给class加上abstract关键字变成抽象类
    ///  普通类实现接口的必须要实现接口里面的方法，抽象类实现接口不用实现接口里面的方法体
    /// </summary>
    public abstract class AbstractClass : IClassInterface   
    {
        public abstract void method3()
        { }
        public abstract void method4()
        { }
    }
}
