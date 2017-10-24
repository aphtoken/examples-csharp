using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using System;
//using System.Numerics;

namespace SimpleContract
{
    public class SimpleContract : SmartContract
    {
        public static int Main( int a, int b, int c)
        {
            if (a > b)
                return a * sum(b, c);
            else
                return sum(a, b) * c;
        }

        public static int sum( int x, int y )
        {
            return x + y;
        }
    }
}
