using System;

namespace MsgPack_Lib.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var bytes = new byte[] { 130, 167, 99, 111, 109, 112, 97, 99, 116, 195, 166, 115, 99, 104, 101, 109, 97, 206, 0, 1, 226, 64 };
            var ss = MessagePack.UnPack<int>(bytes);
            Console.WriteLine("Hello World!" + ss);
        }
    }
}
