using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTest
{
    public class Class1
    {

        public Class1()
        {

        }

        public void method1()
        {
            Console.WriteLine("Method 1");
            Thread.Sleep(2000);
        }

        public async void method2()
        {
            Task.Delay(1000);
            Console.WriteLine("Method 2");
        }

        public async void method3()
        {
            Task.Delay(1000);
            Console.WriteLine("Method 3");
        }

    }
}
