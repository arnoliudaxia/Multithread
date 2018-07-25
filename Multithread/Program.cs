using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;


namespace Multithread
{
    class Program
    {
        static void Main(string[] args)
        {
            MultithreadSample m = new MultithreadSample();
            //无参数新线程
            Thread t = new Thread(m.printOneToTen);
            t.Start();
            m.printOneToTen();
            t.Join();
            //有参数新线程方法1
            t = new Thread(() => m.printOneToX(50));//lambda表达式委托
            t.Start();
            m.printOneToX(20);
            t.Join();
            //有参数新线程方法2
            t = new Thread(m.printOneToX);
            t.Start(30);//在start中传参参数将视为object类型
            m.printOneToX(30);
            ReadKey();


        }

    }
}
