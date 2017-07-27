using System;
using Xunit;

namespace MsgPack_Lib.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Console.Write("first");
            var ss = MessagePack.To();
            var ints = MessagePack.UnPack<int>(null);
            ints = 1;
            Assert.Equal(1,ints);
            Console.Write("first");
        }
    }
}