using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            DoSomethingAsync();
        }

        async Task DoSomethingAsync()
        {
            int value = 13;
            //비동기적으로 1초를 기다린다.
            await Task.Delay(TimeSpan.FromSeconds(1));
            value += 2;
            //비동기적으로 1초를 기다린다.
            await Task.Delay(TimeSpan.FromSeconds(1));
            Trace.WriteLine(value);
        }
    }
}
