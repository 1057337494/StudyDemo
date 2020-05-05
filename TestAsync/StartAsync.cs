using System;
using System.Collections.Generic;
using System.Text;

namespace TestAsync
{
    public class StartAsync
    {
        AsyncMethods _methods = new AsyncMethods();


        public async void TestNotAwait()
        {
            var tk1 = _methods.AsyncMehtodFirst();
            var tk2 = _methods.AsyncMehtodSecond();
            var tk3 = _methods.AsyncMehtodThird();
        }


        public async void TestAwait()
        {
            await _methods.AsyncMehtodFirst();
            await _methods.AsyncMehtodSecond();
            await _methods.AsyncMehtodThird();
        }

    }
}
