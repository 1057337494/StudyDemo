using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestAsync
{
    public class AsyncMethods
    {
        public async Task AsyncMehtodFirst()
        {
            await Task.Run(() => Console.WriteLine($"[{DateTime.Now}:First]"));

        }

        public async Task AsyncMehtodSecond()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(10);
                    Console.WriteLine($"[{DateTime.Now}:Second]");
                }
            });

        }


        public async Task AsyncMehtodThird()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 15; i++)
                {
                    Thread.Sleep(15);
                    Console.WriteLine($"[{DateTime.Now}:Third]");
                }
            });

        }

    }
}
