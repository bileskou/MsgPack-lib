using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using MsgPack_Lib.Core;

namespace MsgPack_Lib
{
    public static class MessagePack
    {
        public static string To()
        {
            return "hello";
        }

        public static byte[] Pack(object obj)
        {
            return null;
        }

        public static T UnPack<T>(byte[] bytes)
        {
            var type = typeof(T);
            var first = bytes[0];
            if ((first >> 7) == 0x00) {
                Console.WriteLine("FixInt");
            } else if ((first >> 4) == 8) {
                Console.WriteLine("FixInt");
                ReadObject<T>(ref bytes);
            } else if ((first >> 5) == 5) {
                Console.WriteLine("FixArray");
            } else if ((first >> 6) == 2) {
                Console.WriteLine("FixStr");
            }
            return default(T);
        }

		public static T ReadObject<T>(ref byte[] bytes)
		{
			GCHandle hObject = GCHandle.Alloc(bytes, GCHandleType.Pinned);

			IntPtr pObject = hObject.AddrOfPinnedObject();
			return default(T);
		}
    }
}
