using System;

namespace MsgPack_Lib.Core
{
    public static class DefineFormatter
	{
        public static byte FixInt = 0x00;

        public static byte FixMap = 0x80;

        public static byte FixArray = 0x90;

        public static byte FixStr = 0xa0;

        public static byte Nil = 0xc0;


	}
}
