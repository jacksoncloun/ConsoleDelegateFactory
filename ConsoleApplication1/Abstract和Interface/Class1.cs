using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract和Interface
{
    #region 接口
    /// <summary>
    /// 接口         【只有方法没有方法体】
    /// 【派生基类中必须实现接口中的方法体   如 method1()和method2() 方法】
    /// </summary>
    public interface IClassInterface
    {
        void method1();
        void method2();
    }
    /// <summary>
    /// 普通类
    /// 继承接口类
    /// 这里讲述抽象类和接口
    /// 一个普通类如果继承了接口，那么必须实现接口里面的所有方法的方法体
    /// 一个普通类如果派生自某个抽象类，那么抽象类里面的方法可以直接调用，而不用继承所有方法
    /// </summary>
    public class NormalClass : IClassInterface   //这个普通类继承了 IClassInterface  这个接口，那么必须要实现接口里面的所有的方法,否则编译是不通过的
    {
        public void method1()
        {
            Console.WriteLine("hello word");
        }
        public void method2() { Console.WriteLine("hello method2"); }
    }
    #endregion
    


    #region 抽象类
    /// <summary>
    /// 抽象类      【可实现方法体也可不实现方法体】
    /// 【实现方法体，被继承，那么普通类就像是一个继承了一个基类一样，不需要去写每个方法的方法体  如 method3()和method4() 方法】
    /// 【主要用法：不实现方法体，被继承，那么普通类就必须通过重载的方式实现该方法的方法体   如 m() 方法    只能确定方法名不能确定里面实现的业务让重载后的方法去实现】
    /// 只要是抽象属性，不管是抽象类还是抽象方法都要加上 abstract关键字，如果抽象类没有加，但是在抽象方法中加了，那么在编译的时候默认这个类就会给class加上abstract关键字变成抽象类
    /// 普通类实现接口的必须要实现接口里面的方法，抽象类实现接口【普通类派生自该抽象类的意思】不用实现接口里面的方法体
    /// </summary>
    public abstract class AbstractClass
    {
        public abstract void m();
        public void method3()
        {
            Console.Write("ddd");
        }
        public void method4()
        {
            Console.Write("ddd");
        }
    }
    /// <summary>
    /// 普通类2
    /// 继承抽象类
    /// </summary>
    public class NormalClass2 : AbstractClass //NormalClass2 这个类继承自AbstractClass抽象类
    {
        public override void m()    //抽象类里面的这个m()方法只能确定方法名，具体里面的实现是不确定的所以写在抽象类中，在这个普通类里面写方法体
        { }
    }
    #endregion
    


    #region 虚函数
    /// <summary>
    /// 飞禽     一个抽象模型  即为一个基类  包含所有类的共有的特征和共同的方法
    /// </summary>
    public class 飞禽
    {
        public string wing { get; set; }  //翅膀
        public string feather { get; set; }  //羽毛
        public virtual bool Fly()
        {
            return true;
        }
    }
    public class 老鹰 : 飞禽
    {
        public override bool Fly()   //重写Fly()方法，张开翅膀大鹏展翅的飞
        {
            return base.Fly();
        }
    }
    public class 猫头鹰 : 飞禽
    {
        public override bool Fly()  //重写Fly()方法，张开翅膀轻飞
        {
            return base.Fly();
        }
    }
    public class 麻雀 : 飞禽
    {
        public override bool Fly()  //重写Fly()方法，一跳一跳能不飞就不飞
        {
            return base.Fly();
        }
    }
    public class MainAction
    {
        public void birdfly(飞禽 bird)
        {
            bird.Fly();
        }
        public void action()
        {
            //声明类必须是飞禽类
            飞禽 fly = new 老鹰();   //实例对象是老鹰，所以会执行老鹰里面的fly()方法
            飞禽 fly2 = new 麻雀();  //实例对象是麻雀，所以会执行麻雀里面的fly()方法
            birdfly(fly);
            birdfly(fly2);
        }
    }
    #endregion    
}
